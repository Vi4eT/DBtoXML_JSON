using System;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace accdb_to_xml_json
{
	public partial class Converter : Form
    {
		private BindingSource currentBindingSource;
		private dynamic currentTableAdapter;
		private dynamic currentTable;
		public Converter()
        {
            InitializeComponent();
        }

        private void Converter_Load(object sender, EventArgs e)
        {
			SetCurrentTable(providerBindingSource.DataMember);
		}

		public void SetCurrentTable(string tableName)
		{
			switch (tableName)
			{
				case "Provider":
					currentBindingSource = providerBindingSource;
					currentTableAdapter = providerTableAdapter;
					currentTable = testDBDataSet.Provider;
					break;
				case "Income":
					currentBindingSource = incomeBindingSource;
					currentTableAdapter = incomeTableAdapter;
					currentTable = testDBDataSet.Income;
					break;
				case "Product":
					currentBindingSource = productBindingSource;
					currentTableAdapter = productTableAdapter;
					currentTable = testDBDataSet.Product;
					break;
			}
			currentTableAdapter.Fill(currentTable);
			dataGridView1.DataSource = currentBindingSource;
		}

		private void buttonToXML_Click(object sender, EventArgs e)
        {
            string xml = "<?xml version='1.0' ?><" + currentBindingSource.DataMember + "Table>";
			currentBindingSource.MoveFirst();
			for (int i = 0; i < currentBindingSource.Count; i++)
			{
				xml += "<" + currentBindingSource.DataMember + ">";
				DataRowView rowView = (DataRowView)currentBindingSource.Current;
				DataRow row = rowView.Row;
				foreach (DataColumn c in row.Table.Columns)
                    xml += "<" + c.ColumnName + ">" + Convert.ToString(row[c.ColumnName]) + "</" + c.ColumnName + ">";
				xml += "</" + currentBindingSource.DataMember + ">";
				currentBindingSource.MoveNext();
            }
            xml += "</" + currentBindingSource.DataMember + "Table>";
            textBoxGrid.Text = xml;
        }

        private void buttonWriteXML_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Table.xml");
            sw.Write(textBoxGrid.Text);
            sw.Close();
        }

        private void buttonReadXML_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Table.xml");
            textBoxFile.Text = sr.ReadLine();
            sr.Close();
        }

        private void buttonToJSON_Click(object sender, EventArgs e)
        {
			string json = "{\"" + currentBindingSource.DataMember + "\":[";
			currentBindingSource.MoveFirst();
			for (int i = 0; i < currentBindingSource.Count; i++)
			{
				json += "{";
				DataRowView rowView = (DataRowView)currentBindingSource.Current;
				DataRow row = rowView.Row;
				foreach (DataColumn c in row.Table.Columns)
				{
					json += "\"" + c.ColumnName + "\":";
					string str = Convert.ToString(row[c.ColumnName]);
					if (row[c.ColumnName].GetType().Name == "Int32")
						json += str;
					else
						json += "\"" + str + "\"";
					json += c.Equals(row.Table.Columns[row.Table.Columns.Count - 1]) ? "}" : ",";
				}
				currentBindingSource.MoveNext();
				json += (i + 1 < currentBindingSource.Count) ? "," : "]}";
			}
			textBoxGrid.Text = json;
		}

        private void buttonWriteJSON_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Table.json");
            sw.Write(textBoxGrid.Text);
            sw.Close();
        }

        private void buttonReadJSON_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Table.json");
            textBoxFile.Text = sr.ReadLine();
            sr.Close();
        }

		private void buttonProvider_Click(object sender, EventArgs e)
		{
			SetCurrentTable(providerBindingSource.DataMember);
		}

		private void buttonIncome_Click(object sender, EventArgs e)
		{
			SetCurrentTable(incomeBindingSource.DataMember);
		}

		private void buttonProduct_Click(object sender, EventArgs e)
		{
			SetCurrentTable(productBindingSource.DataMember);
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			currentBindingSource.EndEdit();
			currentTableAdapter.Update(currentTable);
			currentTableAdapter.Fill(currentTable);
		}
	}
}