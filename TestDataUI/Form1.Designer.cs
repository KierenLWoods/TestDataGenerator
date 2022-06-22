namespace TestDataUI
{
    partial class TestDataGenerator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.testDataObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddRowButton = new System.Windows.Forms.Button();
            this.generateDataButton = new System.Windows.Forms.Button();
            this.testDataObjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataExportcomboBox = new System.Windows.Forms.ComboBox();
            this.rowsRequiredUpDown = new System.Windows.Forms.NumericUpDown();
            this.propertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlTableNameField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataObjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataObjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsRequiredUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.DataType});
            this.dataGridView1.Location = new System.Drawing.Point(109, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(490, 268);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "ColumnName";
            this.ColumnName.HeaderText = "ColumnName";
            this.ColumnName.Name = "ColumnName";
            // 
            // DataType
            // 
            this.DataType.DataPropertyName = "DataType";
            this.DataType.HeaderText = "DataType";
            this.DataType.Name = "DataType";
            // 
            // testDataObjectBindingSource
            // 
            this.testDataObjectBindingSource.DataSource = typeof(DataGeneratorLibrary.TestDataObject);
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(109, 328);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(75, 23);
            this.AddRowButton.TabIndex = 1;
            this.AddRowButton.Text = "Add Row";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // generateDataButton
            // 
            this.generateDataButton.Location = new System.Drawing.Point(643, 388);
            this.generateDataButton.Name = "generateDataButton";
            this.generateDataButton.Size = new System.Drawing.Size(106, 31);
            this.generateDataButton.TabIndex = 3;
            this.generateDataButton.Text = "Generate Data";
            this.generateDataButton.UseVisualStyleBackColor = true;
            this.generateDataButton.Click += new System.EventHandler(this.generateDataButton_Click);
            // 
            // testDataObjectBindingSource1
            // 
            this.testDataObjectBindingSource1.DataSource = typeof(DataGeneratorLibrary.TestDataObject);
            // 
            // dataExportcomboBox
            // 
            this.dataExportcomboBox.FormattingEnabled = true;
            this.dataExportcomboBox.Location = new System.Drawing.Point(489, 388);
            this.dataExportcomboBox.Name = "dataExportcomboBox";
            this.dataExportcomboBox.Size = new System.Drawing.Size(121, 23);
            this.dataExportcomboBox.TabIndex = 4;
            this.dataExportcomboBox.SelectedIndexChanged += new System.EventHandler(this.dataExportcomboBox_SelectedIndexChanged);
            // 
            // rowsRequiredUpDown
            // 
            this.rowsRequiredUpDown.Location = new System.Drawing.Point(39, 388);
            this.rowsRequiredUpDown.Name = "rowsRequiredUpDown";
            this.rowsRequiredUpDown.Size = new System.Drawing.Size(120, 23);
            this.rowsRequiredUpDown.TabIndex = 5;
            this.rowsRequiredUpDown.ValueChanged += new System.EventHandler(this.rowsRequiredUpDown_ValueChanged);
            // 
            // propertiesBindingSource
            // 
            this.propertiesBindingSource.DataMember = "Properties";
            this.propertiesBindingSource.DataSource = this.testDataObjectBindingSource;
            // 
            // sqlTableNameField
            // 
            this.sqlTableNameField.Location = new System.Drawing.Point(349, 389);
            this.sqlTableNameField.Name = "sqlTableNameField";
            this.sqlTableNameField.Size = new System.Drawing.Size(109, 23);
            this.sqlTableNameField.TabIndex = 6;
            // 
            // TestDataGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sqlTableNameField);
            this.Controls.Add(this.rowsRequiredUpDown);
            this.Controls.Add(this.dataExportcomboBox);
            this.Controls.Add(this.generateDataButton);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TestDataGenerator";
            this.Text = "TestDataGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataObjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataObjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsRequiredUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.Button generateDataButton;
        private System.Windows.Forms.BindingSource testDataObjectBindingSource;
        private System.Windows.Forms.BindingSource testDataObjectBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewComboBoxColumn DataType;
        private System.Windows.Forms.ComboBox dataExportcomboBox;
        private System.Windows.Forms.NumericUpDown rowsRequiredUpDown;
        private System.Windows.Forms.BindingSource propertiesBindingSource;
        private System.Windows.Forms.TextBox sqlTableNameField;
    }
}
