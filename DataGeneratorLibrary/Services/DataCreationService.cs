using DataGeneratorLibrary.DataModels;
using DataGeneratorLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGeneratorLibrary.Services
{
    public class DataCreationService
    {
       
        readonly TestDataObject _testDataObject;
        List<CreatedDataObject> _createdDataObjectList = new List<CreatedDataObject> ();
        int _rowCount;
        public DataCreationService(TestDataObject testDataObject,int rowCount)
        {
            
            _testDataObject = testDataObject;
            _rowCount = rowCount;
        }
        //private static DataCreationService _instance;
        //public static DataCreationService GetDataCreationService( TestDataObject dataList, int rowCount)
        //{
        //    if (_instance == null)
        //    {
        //    _instance = new DataCreationService(dataList, rowCount);             
        //    }
        //    return DataCreationService._instance;
            
        //}

        public List<CreatedDataObject> CreateTestData()
        {
            int start = 1;
            while(start <= _rowCount)
            {
                CreatedDataObject  createdDataObject = new CreatedDataObject();
                foreach (var row in _testDataObject.Properties)
                {
                    
                    switch (row.DataType)
                    {
                        case (DataTypeEnums.FirstName):
                            {
                                FirstNameDataCreationService firstNameDataCreator = new FirstNameDataCreationService();
                                createdDataObject.Properties.Add(firstNameDataCreator.GenerateData(row.ColumnName));
                                break;
                            }
                        case (DataTypeEnums.LastName):
                            {
                                LastNameDataCreationService lastNameDataCreator = new LastNameDataCreationService();
                                createdDataObject.Properties.Add(lastNameDataCreator.GenerateData(row.ColumnName));
                                break;
                            }
                    }
                }
                _createdDataObjectList.Add(createdDataObject);
                start++;
            }
            
            return _createdDataObjectList;
        }
    }
}
