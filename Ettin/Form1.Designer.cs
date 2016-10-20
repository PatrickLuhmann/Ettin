namespace Ettin
{
	partial class Form1
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
			this.buttonNewDataSet = new System.Windows.Forms.Button();
			this.buttonNewDataTable = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonNewColumn = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.comboBoxTableList = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonNewDataSet
			// 
			this.buttonNewDataSet.Location = new System.Drawing.Point(13, 13);
			this.buttonNewDataSet.Name = "buttonNewDataSet";
			this.buttonNewDataSet.Size = new System.Drawing.Size(108, 23);
			this.buttonNewDataSet.TabIndex = 0;
			this.buttonNewDataSet.Text = "New DataSet";
			this.buttonNewDataSet.UseVisualStyleBackColor = true;
			this.buttonNewDataSet.Click += new System.EventHandler(this.buttonNewDataSet_Click);
			// 
			// buttonNewDataTable
			// 
			this.buttonNewDataTable.Location = new System.Drawing.Point(128, 13);
			this.buttonNewDataTable.Name = "buttonNewDataTable";
			this.buttonNewDataTable.Size = new System.Drawing.Size(113, 23);
			this.buttonNewDataTable.TabIndex = 1;
			this.buttonNewDataTable.Text = "New DataTable";
			this.buttonNewDataTable.UseVisualStyleBackColor = true;
			this.buttonNewDataTable.Click += new System.EventHandler(this.buttonNewDataTable_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(13, 43);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridView1.Size = new System.Drawing.Size(1028, 840);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
			// 
			// buttonNewColumn
			// 
			this.buttonNewColumn.Location = new System.Drawing.Point(248, 13);
			this.buttonNewColumn.Name = "buttonNewColumn";
			this.buttonNewColumn.Size = new System.Drawing.Size(75, 23);
			this.buttonNewColumn.TabIndex = 3;
			this.buttonNewColumn.Text = "New Column";
			this.buttonNewColumn.UseVisualStyleBackColor = true;
			this.buttonNewColumn.Click += new System.EventHandler(this.buttonNewColumn_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(330, 13);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(211, 20);
			this.textBox1.TabIndex = 4;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Int32",
            "UInt32",
            "String",
            "DateTime",
            "Decimal"});
			this.comboBox1.Location = new System.Drawing.Point(548, 13);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 5;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(676, 13);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(107, 23);
			this.buttonSave.TabIndex = 6;
			this.buttonSave.Text = "Save DataSet";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// comboBoxTableList
			// 
			this.comboBoxTableList.FormattingEnabled = true;
			this.comboBoxTableList.Location = new System.Drawing.Point(790, 13);
			this.comboBoxTableList.Name = "comboBoxTableList";
			this.comboBoxTableList.Size = new System.Drawing.Size(121, 21);
			this.comboBoxTableList.TabIndex = 7;
			this.comboBoxTableList.SelectedIndexChanged += new System.EventHandler(this.comboBoxTableList_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1054, 897);
			this.Controls.Add(this.comboBoxTableList);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.buttonNewColumn);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonNewDataTable);
			this.Controls.Add(this.buttonNewDataSet);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonNewDataSet;
		private System.Windows.Forms.Button buttonNewDataTable;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonNewColumn;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.ComboBox comboBoxTableList;
	}
}

