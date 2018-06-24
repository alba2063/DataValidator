using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataValidatir
{
	class DB_Adapter
	{
		private static SQLiteConnection sqlcon;
		private static readonly string connetionString = Reader.conString; //Connection string from Validator_ini.xml

		private static void SetConnection()
		{
			sqlcon = new SQLiteConnection("Data Source=validatordb.sqlite;Version=3;New=False;Compress=True;");
		}


		public DataTable ReadLocation(int index)
		{
			DataTable dt = new DataTable();
			string sql;

			switch (index)
			{
				case 0:
					sql = "SELECT * FROM Gocator1";
					break;
				case 1:
					sql = "SELECT * FROM Gocator2";
					break;
				case 2:
					sql = "SELECT * FROM Gocator3";
					break;
				case 3:
					sql = "SELECT * FROM Gocator20x0";
					break;
				default:
					sql = string.Empty;
					break;
			}

			using (var sqlConn = new SQLiteConnection(connetionString))
			{
				var cmd = new SQLiteCommand(sql, sqlConn);

				sqlConn.Open();
				var reader = cmd.ExecuteReader();

				dt.Load(reader);

				sqlConn.Close();
			}

			return dt;
		}

		public int InsertIntoTable(SensorCollection sensors, int index)
		{
			int r = 0;
			string sql;

			switch (index)
			{
				case 0:
					sql = "INSERT INTO Gocator1 (sn, model, wip, time, folder) "
						+ "VALUES (@sn, @model, @wip, @time, @folder)";
					break;
				case 1:
					sql = "INSERT INTO Gocator2 (sn, model, wip, time, folder) "
						+ "VALUES (@sn, @model, @wip, @time, @folder)";
					break;
				case 2:
					sql = "INSERT INTO Gocator3 (sn, model, wip, time, folder) "
						+ "VALUES (@sn, @model, @wip, @time, @folder)";
					break;
				case 3:
					sql = "INSERT INTO Gocator20x0 (sn, model, wip, time, folder) "
						+ "VALUES (@sn, @model, @wip, @time, @folder)";
					break;
				default:
					sql = string.Empty;
					break;
			}

			using (var sqlConn = new SQLiteConnection(connetionString))
			{
				var cmd = new SQLiteCommand(sql, sqlConn);

				sqlConn.Open();

				foreach (Sensor sensor in sensors)
				{
					cmd.Parameters.AddWithValue("@sn", sensor.Sn);
					cmd.Parameters.AddWithValue("@model", sensor.Model);
					cmd.Parameters.AddWithValue("@wip", sensor.Wip);
					cmd.Parameters.AddWithValue("@time", sensor.Time);
					cmd.Parameters.AddWithValue("@folder", sensor.Location);

					r = cmd.ExecuteNonQuery();
				}
				sqlConn.Close();
			}

			return r;
		}

		public int ClearTable(int index)
		{
			int r = 0;

			string sql;

			switch (index)
			{
				case 0:
					sql = "DELETE FROM Gocator1";
					break;
				case 1:
					sql = "DELETE FROM Gocator2";
					break;
				case 2:
					sql = "DELETE FROM Gocator3";
					break;
				case 3:
					sql = "DELETE FROM Gocator20x0";
					break;
				default:
					sql = string.Empty;
					break;
			}

			using (var sqlConn = new SQLiteConnection(connetionString))
			{
				var cmd = new SQLiteCommand(sql, sqlConn);
				sqlConn.Open();

				r = cmd.ExecuteNonQuery();
				sqlConn.Close();
			}

				return r;
		}
	}
}
