using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DataValidatir
{
	class Reader
	{
		private string setFile = "Validator_ini.xml";
		private string snLength;
		public static string conString;

		//**********************************************************************************************************
		//**                                        Read ini file                                                 **
		//**********************************************************************************************************

		public CellCollection ReadIni()
		{
			CellCollection cells = new CellCollection();


			if (!File.Exists(setFile))
			{
				Writer writer = new Writer();
				writer.WriteSettings(setFile);
				Application.Restart();

				//MessageBox.Show(ex.Message);
			}
			else
			{
				try
				{
					XmlDocument doc = new XmlDocument();
					doc.Load(setFile);

					XmlNodeList nodes = doc.DocumentElement.SelectNodes("/Settings/Cells/Cell");

					conString = doc.DocumentElement.SelectSingleNode("/Settings/ConnectionString").InnerText;
					snLength = doc.DocumentElement.SelectSingleNode("/Settings/SnLength").InnerText;

					foreach (XmlNode node in nodes)
					{
						//if (!node.SelectSingleNode("Name").InnerText.Equals(""))
						Cell cell = new Cell();

						var index = node.SelectSingleNode("Index").InnerText;
						int k;

						if (Int32.TryParse(index, out k))
						{
							cell.Index = k;
						}
						else
						{
							cell.Index = 100;
							MessageBox.Show("Validator_ini.xml wrong Index value");
						}
						cell.Name = node.SelectSingleNode("Cell_name").InnerText;
						cell.Location = node.SelectSingleNode("Folder").InnerText;

						cells.Add(cell);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error reading Validator_ini.xml");
					//throw new ReadFileErrorException(setFile, ex);
				}
			}

			return cells;
		}

		//**********************************************************************************************************
		//**                                      XML file Validator                                              **
		//**********************************************************************************************************

		public static bool IsValidXml(string xml)
		{
			XmlDocument doc = new XmlDocument();

			try
			{
				doc.Load(xml);
				return true;
			}
			catch
			{
				return false;
			}
		}

		//**********************************************************************************************************
		//**                                             Get DB Date                                              **
		//**********************************************************************************************************

		public string GrtDBDate(string db_file)
		{
			string db_date;

			if (!File.Exists(db_file))
			{
				db_date = "No DB file";
			}
			else
			{
				db_date = File.GetLastWriteTime(db_file).ToLocalTime().ToString();
			}

				return db_date;
		}

		//**********************************************************************************************************
		//**                                      Collect SensorCollection                                        **
		//**********************************************************************************************************

		public SensorCollection ReadCell(string location)
		{
			SensorCollection sensors = new SensorCollection();
			string sn;

			if (Directory.Exists(location))
			{
				foreach (string path in Directory.GetDirectories(location))
				{
					sn = path.Remove(0, location.Length + 1);
					if (!sn.StartsWith("SN"))
					{
						continue;
					}
					string verPath = path + "\\" + sn + ".xml"; //path to main XML file

					Sensor sensor = new Sensor();

					Regex rgx = new Regex(@"[^0-9]");

					if (!File.Exists(verPath))
					{
						sensor.Sn = -1;
						sensor.Model = string.Format("No file {0}.xml", sn);
						sensor.Location = path;
					}
					else
					{
						//sensor.Time = File.GetLastWriteTime(verPath).ToUniversalTime().ToString();
						sensor.Time = File.GetLastWriteTime(verPath).ToLocalTime();

						XmlDocument doc = new XmlDocument();

						if (IsValidXml(verPath))
						{
							doc.Load(verPath);

							XmlNodeList nodes = doc.DocumentElement.SelectNodes("/Entries/Entries/Item");

							//bool f = false;//

							foreach (XmlNode node in nodes)
							{
								if (!node.SelectSingleNode("SensorModel").InnerText.Equals(""))
								{
									sensor.Model = node.SelectSingleNode("SensorModel").InnerText;
								}

								if (!node.SelectSingleNode("SensorId").InnerText.Equals(""))
								{
									var sntext = node.SelectSingleNode("SensorId").InnerText;

									//remove symbols
									var snnumb = rgx.Replace(sntext, "");

									//remove leading zerros
									int number;
									bool result = Int32.TryParse(snnumb, out number);
									if (result)
									{
										sensor.Sn = number;
									}
									else
									{
										sensor.Sn = -3;										
									}
								}

								if (node.SelectSingleNode("Type").InnerText.Equals("Initialize"))
								{
									if (node.SelectSingleNode("Values") != null)
									{
										foreach (XmlNode innerNode in node.SelectSingleNode("Values"))
										{
											if (innerNode.Name.Equals("WorkOrder"))
											{
												sensor.Wip = innerNode.InnerText;
												//f = true;
											}
										}
									}
								}
								sensor.Location = path;
							}
						}
						else
						{
							sensor.Sn = -2;
							sensor.Model = string.Format("{0}.xml is not valid", sn);
							sensor.Location = path;
						}
					}

					sensors.Add(sensor);
				}
			}

			return sensors;
		}
	}
}
