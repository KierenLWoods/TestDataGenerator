using DataGeneratorLibrary.DataModels;
using DataGeneratorLibrary.Enums;
using DataGeneratorLibrary.Helpers;
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
                                NameHelper<FirstName> nameHelper = new NameHelper<FirstName>();                                
                                NameCreationService<FirstName> nameCreationService = new NameCreationService<FirstName>();                         
                                createdDataObject.Properties.Add(nameCreationService.GenerateData(row.ColumnName, nameHelper.GetNamesFromFile("\\NameFiles\\FirstNames.txt")));
                                break;
                            }
                        case (DataTypeEnums.LastName):
                            {
                                NameHelper<Surnames> nameHelper = new NameHelper<Surnames>();
                                NameCreationService<Surnames> nameCreationService = new NameCreationService<Surnames>();
                                createdDataObject.Properties.Add(nameCreationService.GenerateData(row.ColumnName, nameHelper.GetNamesFromFile("\\NameFiles\\Surnames.txt")));
                                break;
                            }
                        case (DataTypeEnums.FullName):
                            {
                                NameHelper<FullName> nameHelper = new NameHelper<FullName>();
                                NameCreationService<FullName> nameCreationService = new NameCreationService<FullName>();
                                createdDataObject.Properties.Add(nameCreationService.GenerateData(row.ColumnName, nameHelper.GetNamesFromFile("\\NameFiles\\FullNames.txt")));
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
