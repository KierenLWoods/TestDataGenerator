using DataGeneratorLibrary.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGeneratorLibrary.DataModels
{
    public class PropertiesModel :  INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    
        private string columnName = string.Empty;
        [DisplayName("ColumnName")]
        public string ColumnName
        {
            get
            {
                return columnName;
            }
            set
            {
                if (value != columnName)
                {
                    columnName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }
        [DisplayName("DataType")]
        public DataTypeEnums DataType { get; set; }
    }
}
