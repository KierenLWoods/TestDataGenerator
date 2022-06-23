using DataGeneratorLibrary;
using DataGeneratorLibrary.DataModels;
using DataGeneratorLibrary.Enums;
using DataGeneratorLibrary.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDataUI
{
    public partial class TestDataGenerator : Form
    {
        TestDataObject testDataObject;
        int rowsRequired = 1;
        DataExportEnums exportEnum;
        public TestDataGenerator()
        {
            InitializeComponent();            
            testDataObject = new TestDataObject();
            var comboBox = (DataGridViewComboBoxColumn)dataGridView1.Columns["DataType"];
            comboBox.DataSource = Enum.GetValues(typeof(DataTypeEnums));
            dataGridView1.DataSource = testDataObject.Properties;
            dataExportcomboBox.DataSource = Enum.GetValues(typeof(DataExportEnums));
            dataExportcomboBox.SelectedItem = null;
            dataExportcomboBox.SelectedText = "--Select--";
            sqlTableNameField.Visible = false;

        }




        private void AddRowButton_Click(object sender, EventArgs e)
        {
            testDataObject.Properties.Add(new PropertiesModel { ColumnName = "*Enter-Column-Name*" });
            // dataGridView1.DataSource = testDataObject;
        }

        private void generateDataButton_Click(object sender, EventArgs e)
        {

            DataGeneratorService dataGenerator = new DataGeneratorService(rowsRequired, testDataObject, exportEnum,sqlTableNameField.Text);
            dataGenerator.CreateTestData();            
            DataExtractionForm dataExtractionForm = new DataExtractionForm(dataGenerator.ExportData());
            dataExtractionForm.ShowDialog();
           
        }

        private void rowsRequiredUpDown_ValueChanged(object sender, EventArgs e)
        {
            rowsRequired = Decimal.ToInt32(rowsRequiredUpDown.Value);
        }

        private void dataExportcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (dataExportcomboBox.SelectedValue != null)
            {
                exportEnum = Enum.Parse<DataExportEnums>(dataExportcomboBox.SelectedValue.ToString());
                if(exportEnum.ToString() == "Sql")
                {
                    sqlTableNameField.Visible = true;
                    sqlTableNameField.Enabled = true;
                }
                else
                {
                    sqlTableNameField.Visible=false;
                }
            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            DataGridViewRow row = grid.Rows[e.RowIndex];
            DataGridViewColumn col = grid.Columns[e.ColumnIndex];
            if (row.DataBoundItem != null && col.DataPropertyName.Contains("."))
            {
                string[] props = col.DataPropertyName.Split('.');
                PropertyInfo propInfo = row.DataBoundItem.GetType().GetProperty(props[0]);
                object val = propInfo.GetValue(row.DataBoundItem, null);
                for (int i = 1; i < props.Length; i++)
                {
                    propInfo = val.GetType().GetProperty(props[i]);
                    val = propInfo.GetValue(val, null);
                }
                e.Value = val;
            }
        }
    }

   
}
