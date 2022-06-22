using DataGeneratorLibrary.DataModels;
using DataGeneratorLibrary.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGeneratorLibrary
{
    public class TestDataObject : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public BindingList<PropertiesModel> Properties { get; set; } = new BindingList<PropertiesModel>();
   
   

     
       
    }
}
