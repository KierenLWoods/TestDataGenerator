using DataGeneratorLibrary.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGeneratorLibrary.Services
{
    public class LastNameDataCreationService
    {
        //This class should return a random first Name
        private static Random rand = new Random(DateTime.Now.Second);

        public CreatedDataPropertiesModel GenerateData(string columnName)
        {           
            SurnameFileReader surnames = SurnameFileReader.GetSurnameFileReader();           
            var createdPropertiesObject = new CreatedDataPropertiesModel { ColumnName = columnName };
            int index = rand.Next(0, surnames.Surnames.Count);
            createdPropertiesObject.Value = surnames.Surnames[index].Surname;
            return createdPropertiesObject;
        }
    }

}
