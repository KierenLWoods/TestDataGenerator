using DataGeneratorLibrary.DataModels;
using DataGeneratorLibrary.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDataUI
{
    public partial class DataExtractionForm : Form
    {
        private BindingList<SQLObject> sqlData;
        public DataExtractionForm(List<IBaseExtractionData> data)
        {
            InitializeComponent();
           dataGridView1.DataSource = SourceHelper.AutoCast(data);
        }

       
    }
}
