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
			comboBox1.SelectedIndex = 0;
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

			// Add to the table list and make it the one that is displayed.
			comboBoxTableList.Items.Add(textBox1.Text);
			int idx = comboBoxTableList.FindStringExact(textBox1.Text);
			//comboBoxTableList.SelectedIndex = idx;
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

			string type = comboBox1.SelectedItem.ToString();
			System.Diagnostics.Debug.WriteLine("Column type: " + type);

			DataTable dt = (DataTable)dataGridView1.DataSource;
			if (type == "Int32")
				dt.Columns.Add(textBox1.Text, typeof(Int32));
			else if (type == "UInt32")
				dt.Columns.Add(textBox1.Text, typeof(UInt32));
			else if (type == "String")
				dt.Columns.Add(textBox1.Text, typeof(String));
			else if (type == "DateTime")
				dt.Columns.Add(textBox1.Text, typeof(DateTime));
			else if (type == "Decimal")
				dt.Columns.Add(textBox1.Text, typeof(Decimal));
			else
				dt.Columns.Add(textBox1.Text, typeof(int));

#if false
			if (textBox1.Text == "ID")
			{
				dt.Columns["ID"].AutoIncrement = true;
				dt.Columns["ID"].AutoIncrementSeed = 1;
				dt.Columns["ID"].AutoIncrementStep = 1;
			}
#endif
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			// Pop up a save file dialog
			SaveFileDialog fileDialog = new SaveFileDialog();
			fileDialog.InitialDirectory = "c:\\";
			fileDialog.Filter = "XML files|*.xml";
			fileDialog.OverwritePrompt = true;

			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				System.Diagnostics.Debug.WriteLine("The user selected the file " + fileDialog.FileName);

				// Save the DataSet to the file
				CurrDataSet.WriteXml(fileDialog.FileName, XmlWriteMode.WriteSchema);
			}
		}

		private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGridView1.SelectedCells.Count < 1)
			{
				System.Diagnostics.Debug.WriteLine("CellEnter callback but no cells are selected.");
				return;
			}
			StringBuilder sb = new StringBuilder();
			sb.Append("Entered a cell of type ");
			sb.Append(dataGridView1.SelectedCells[0].OwningColumn.ValueType.ToString());
			sb.Append(".");
			System.Diagnostics.Debug.WriteLine(sb.ToString());

			string type = dataGridView1.SelectedCells[0].OwningColumn.ValueType.ToString();
			// Remove the "System." at the beginning as it is not used in the combo box.
			type = type.Replace("System.", string.Empty);
			int idx = comboBox1.FindStringExact(type);
			comboBox1.SelectedIndex = idx;
#if false
			foreach (object it in comboBox1.Items)
			{
				if (it.ToString() == dataGridView1.SelectedCells[0].OwningColumn.ValueType.ToString())
				{
					System.Diagnostics.Debug.WriteLine(it.ToString());

				}
			}
#endif
		}

		private void comboBoxTableList_SelectedIndexChanged(object sender, EventArgs e)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("Event SelectedIndexChanged. ");
			int idx = comboBoxTableList.SelectedIndex;
			sb.Append("New index = " + idx.ToString() + ". ");
			string tableName = comboBoxTableList.Items[idx].ToString();
			sb.Append("New table name = " + tableName);

			System.Diagnostics.Debug.WriteLine(sb.ToString());

			// Display the selected table.
			dataGridView1.DataSource = CurrDataSet.Tables[tableName];
		}
	}
}
