namespace DataValidatir
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControlMain = new System.Windows.Forms.TabControl();
			this.g20x0 = new System.Windows.Forms.TabPage();
			this.dataGridViewG20x0 = new System.Windows.Forms.DataGridView();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.comboBoxCell = new System.Windows.Forms.ComboBox();
			this.btnLoadTable = new System.Windows.Forms.Button();
			this.btnEmptyTable = new System.Windows.Forms.Button();
			this.btnUpdateDB = new System.Windows.Forms.Button();
			this.statusStripMain = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelDBTime = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControlMain.SuspendLayout();
			this.g20x0.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewG20x0)).BeginInit();
			this.statusStripMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlMain
			// 
			this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlMain.Controls.Add(this.g20x0);
			this.tabControlMain.Location = new System.Drawing.Point(139, 12);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(745, 399);
			this.tabControlMain.TabIndex = 0;
			// 
			// g20x0
			// 
			this.g20x0.Controls.Add(this.dataGridViewG20x0);
			this.g20x0.Location = new System.Drawing.Point(4, 22);
			this.g20x0.Name = "g20x0";
			this.g20x0.Padding = new System.Windows.Forms.Padding(3);
			this.g20x0.Size = new System.Drawing.Size(737, 373);
			this.g20x0.TabIndex = 0;
			this.g20x0.Text = "Table View";
			this.g20x0.UseVisualStyleBackColor = true;
			// 
			// dataGridViewG20x0
			// 
			this.dataGridViewG20x0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewG20x0.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewG20x0.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewG20x0.Name = "dataGridViewG20x0";
			this.dataGridViewG20x0.Size = new System.Drawing.Size(731, 367);
			this.dataGridViewG20x0.TabIndex = 0;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(49, 73);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(84, 23);
			this.btnUpdate.TabIndex = 1;
			this.btnUpdate.Text = "View Table";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// comboBoxCell
			// 
			this.comboBoxCell.FormattingEnabled = true;
			this.comboBoxCell.Location = new System.Drawing.Point(12, 46);
			this.comboBoxCell.Name = "comboBoxCell";
			this.comboBoxCell.Size = new System.Drawing.Size(121, 21);
			this.comboBoxCell.TabIndex = 2;
			// 
			// btnLoadTable
			// 
			this.btnLoadTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnLoadTable.Location = new System.Drawing.Point(49, 352);
			this.btnLoadTable.Name = "btnLoadTable";
			this.btnLoadTable.Size = new System.Drawing.Size(84, 23);
			this.btnLoadTable.TabIndex = 3;
			this.btnLoadTable.Text = "Update Table";
			this.btnLoadTable.UseVisualStyleBackColor = true;
			this.btnLoadTable.Click += new System.EventHandler(this.btnLoadTable_Click);
			// 
			// btnEmptyTable
			// 
			this.btnEmptyTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnEmptyTable.Location = new System.Drawing.Point(49, 323);
			this.btnEmptyTable.Name = "btnEmptyTable";
			this.btnEmptyTable.Size = new System.Drawing.Size(84, 23);
			this.btnEmptyTable.TabIndex = 1;
			this.btnEmptyTable.Text = "Empty Table";
			this.btnEmptyTable.UseVisualStyleBackColor = true;
			this.btnEmptyTable.Click += new System.EventHandler(this.btnEmptyTable_Click);
			// 
			// btnUpdateDB
			// 
			this.btnUpdateDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnUpdateDB.Location = new System.Drawing.Point(49, 381);
			this.btnUpdateDB.Name = "btnUpdateDB";
			this.btnUpdateDB.Size = new System.Drawing.Size(84, 23);
			this.btnUpdateDB.TabIndex = 1;
			this.btnUpdateDB.Text = "Update DB";
			this.btnUpdateDB.UseVisualStyleBackColor = true;
			this.btnUpdateDB.Click += new System.EventHandler(this.btnUpdateDB_Click);
			// 
			// statusStripMain
			// 
			this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStatus,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelDBTime});
			this.statusStripMain.Location = new System.Drawing.Point(0, 412);
			this.statusStripMain.Name = "statusStripMain";
			this.statusStripMain.Size = new System.Drawing.Size(884, 24);
			this.statusStripMain.TabIndex = 4;
			this.statusStripMain.Text = "statusStrip1";
			// 
			// toolStripStatusLabelStatus
			// 
			this.toolStripStatusLabelStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
			this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(43, 19);
			this.toolStripStatusLabelStatus.Text = "Status";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(874, 19);
			this.toolStripStatusLabel1.Spring = true;
			// 
			// toolStripStatusLabelDBTime
			// 
			this.toolStripStatusLabelDBTime.Name = "toolStripStatusLabelDBTime";
			this.toolStripStatusLabelDBTime.Size = new System.Drawing.Size(76, 19);
			this.toolStripStatusLabelDBTime.Text = "DB DateTime";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 436);
			this.Controls.Add(this.statusStripMain);
			this.Controls.Add(this.btnUpdateDB);
			this.Controls.Add(this.btnEmptyTable);
			this.Controls.Add(this.btnLoadTable);
			this.Controls.Add(this.comboBoxCell);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.tabControlMain);
			this.Name = "MainForm";
			this.Text = "Data Validator";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabControlMain.ResumeLayout(false);
			this.g20x0.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewG20x0)).EndInit();
			this.statusStripMain.ResumeLayout(false);
			this.statusStripMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControlMain;
		private System.Windows.Forms.TabPage g20x0;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.DataGridView dataGridViewG20x0;
		private System.Windows.Forms.ComboBox comboBoxCell;
		private System.Windows.Forms.Button btnLoadTable;
		private System.Windows.Forms.Button btnEmptyTable;
		private System.Windows.Forms.Button btnUpdateDB;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDBTime;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip statusStripMain;
	}
}

