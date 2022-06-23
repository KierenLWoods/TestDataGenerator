using DataGeneratorLibrary.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGeneratorLibrary.Services
{
    public class NameCreationService<T> where T : IName
    {
        private static Random rand = new Random(DateTime.Now.Second);
       
        public CreatedDataPropertiesModel GenerateData(string columnName,List<T> nameObjects)
        {
            
            var createdPropertiesObject = new CreatedDataPropertiesModel { ColumnName = columnName };
            int index = rand.Next(0, nameObjects.Count);
            createdPropertiesObject.Value = nameObjects[index].Name;
            return createdPropertiesObject;
        }
    }
}
