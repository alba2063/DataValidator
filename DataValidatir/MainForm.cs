using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataValidatir
{
	public partial class MainForm : Form
	{
		CellCollection cells;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			GetIni();
		}

		private void GetIni()
		{
			Reader reader = new Reader();
			cells = reader.ReadIni();

			comboBoxCell.DataSource = cells;
			comboBoxCell.DisplayMember = "Name";
			comboBoxCell.ValueMember = "Location";
			comboBoxCell.DropDownStyle = ComboBoxStyle.DropDownList;
			toolStripStatusLabelStatus.Text = "Ready";

			btnEmptyTable.Enabled = false;
			btnUpdateDB.Enabled = false;

			DbDate();
		}

		//**********************************************************************************************************
		//**                                         Get DB file Date                                             **
		//**********************************************************************************************************

		private void DbDate()
		{
			string conString = Reader.conString;
			string conStringPath = conString.Substring(12, conString.Length - 12 - 11);

			Reader reader = new Reader();
			string db_date = reader.GrtDBDate(conStringPath);

			toolStripStatusLabelDBTime.Text = string.Format("Last DB update: {0}", db_date);
		}

		//**********************************************************************************************************
		//**                                        View selected table                                           **
		//**********************************************************************************************************

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			//toolStripStatusLabelStatus.Text = "Loading ...";
			Cursor.Current = Cursors.WaitCursor;

			Cell cell = new Cell();
			cell = comboBoxCell.SelectedItem as Cell;

			DataTable dt = new DataTable();

			DB_Adapter adapter = new DB_Adapter();

			dt = adapter.ReadLocation(cell.Index);

			dataGridViewG20x0.DataSource = dt;

			Cursor.Current = Cursors.Default;
			toolStripStatusLabelStatus.Text = string.Format("Table {0}; {1} rows",cell.Name, dt.Rows.Count);
		}

		//**********************************************************************************************************
		//**                                    Load DB table from network                                        **
		//**********************************************************************************************************

		private void btnLoadTable_Click(object sender, EventArgs e)
		{
			//toolStripStatusLabelStatus.Text = "Updating DB ...";
			Cursor.Current = Cursors.WaitCursor;

			SensorCollection sensors = new SensorCollection();

			Cell cell = new Cell();
			cell = comboBoxCell.SelectedItem as Cell;

			if (cell.Index > 10)
			{
				return;
			}

			DB_Adapter adapter = new DB_Adapter();
			adapter.ClearTable(cell.Index);

			Reader reader = new Reader();

			sensors = reader.ReadCell(cell.Location);

			adapter.InsertIntoTable(sensors, cell.Index);

			DataTable dt = new DataTable();

			dt = adapter.ReadLocation(cell.Index);

			dataGridViewG20x0.DataSource = dt;

			DbDate();

			Cursor.Current = Cursors.Default;
			toolStripStatusLabelStatus.Text = string.Format("Table {0}; {1} rows", cell.Name, dt.Rows.Count);
		}

		//**********************************************************************************************************
		//**                                          Clear a Table                                               **
		//**********************************************************************************************************

		private void btnEmptyTable_Click(object sender, EventArgs e)
		{
			//toolStripStatusLabelStatus.Text = "Deleting ...";
			Cursor.Current = Cursors.WaitCursor;

			Cell cell = new Cell();
			cell = comboBoxCell.SelectedItem as Cell;

			if (cell.Index > 10)
			{
				return;
			}

			DB_Adapter adapter = new DB_Adapter();
			adapter.ClearTable(cell.Index);

			DataTable dt = new DataTable();

			dt = adapter.ReadLocation(cell.Index);

			dataGridViewG20x0.DataSource = dt;

			Cursor.Current = Cursors.Default;
			toolStripStatusLabelStatus.Text = string.Format("Table {0}; {1} rows", cell.Name, dt.Rows.Count);
		}

		private void btnUpdateDB_Click(object sender, EventArgs e)
		{

		}
	}
}
