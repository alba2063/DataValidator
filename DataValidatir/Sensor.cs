using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataValidatir
{
	class Sensor
	{
		private Int32 sn;
		private string model;
		private string wip;
		private string location;
		private DateTime time;

		public Int32 Sn { get => sn; set => sn = value; }
		public string Model { get => model; set => model = value; }
		public string Wip { get => wip; set => wip = value; }
		public string Location { get => location; set => location = value; }
		public DateTime Time { get => time; set => time = value; }
	}
}
