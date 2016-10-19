using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ettin
{
	public partial class Form1 : Form
	{
		DataSet CurrDataSet;

		public Form1()
		{
			InitializeComponent();
		}

		private void buttonNewDataTable_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Debug.WriteLine("Button: New DataTable");

			if (CurrDataSet == null)
			{
				MessageBox.Show("ERROR: No DataSet present.");
				return;
			}

			// Ask the user for a name for the table.
			// For now, just take it from textBox1.
			if (textBox1.Text == "")
			{
				MessageBox.Show("ERROR: Must supply name for new DataTable.");
				return;
			}

			// Create the table and add it to the DataSet.
			DataTable newDataTable = new DataTable(textBox1.Text);
			// pjl Add debug column
			newDataTable.Columns.Add("ID", typeof(UInt32));
			newDataTable.PrimaryKey = new DataColumn[] { newDataTable.Columns["ID"] };
			newDataTable.Columns["ID"].AutoIncrement = true;
			newDataTable.Columns["ID"].AutoIncrementSeed = 1;
			newDataTable.Columns["ID"].AutoIncrementStep = 1;

			CurrDataSet.Tables.Add(newDataTable);

			// Display the new table.
			dataGridView1.DataSource = newDataTable;
			//dataGridView1.Columns["testCol"].Visible = true;
		}

		private void buttonNewDataSet_Click(object sender, EventArgs e)
		{
			CurrDataSet = new DataSet("MyDataSet");
		}

		private void buttonNewColumn_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				MessageBox.Show("ERROR: Must supply name for new DataColumn.");
				return;
			}

			// How do we know which DataTable is currently displayed?
			// Can we add to the grid version and have it change the one in CurrDataSet?
			// I guess there is only one way to find out.
			DataTable dt = (DataTable)dataGridView1.DataSource;
			dt.Columns.Add(textBox1.Text, typeof(int));
		}
	}
}
