using DataGeneratorLibrary.DataModels;
using DataGeneratorLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGeneratorLibrary.Services
{
    public class DataGeneratorService
    {
        //Take List of TestDataObjects, Rows Required, DataExportType
        private readonly int _rows;
        readonly TestDataObject _dataObject;
        readonly DataExportEnums _exportEnums;
        private  DataCreationService _creationService;
        private List<CreatedDataObject> _createdDataObject;
        private DataExtractorService _dataExtractorService;
        private List<IBaseExtractionData> _extractedData;
        string sqlTableName;
        public DataGeneratorService(int rows, TestDataObject testDataObjects,DataExportEnums exportEnums,string tableName = null)
        {
            _rows = rows;
            _dataObject = testDataObjects;
            _exportEnums = exportEnums;
            _creationService = new DataCreationService(testDataObjects, _rows);
            _dataExtractorService = new DataExtractorService(_createdDataObject,_exportEnums);
            sqlTableName = tableName;
           
        }
        private static  DataGeneratorService _instance;

        //public static DataGeneratorService GetGeneratorService(int rows, TestDataObject testDataObject, DataExportEnums exportEnums,string tablename = null)
        //{
        //    if (_instance == null)
        //    {
        //        _instance = new DataGeneratorService(rows, testDataObject, exportEnums,tablename);
        //    }
        //    return _instance;
        //}

        //Create Test Data
        public List<CreatedDataObject> CreateTestData()
        {
            _createdDataObject = _creationService.CreateTestData();
            return _createdDataObject;
        }

        //Export Data 
        public List<IBaseExtractionData> ExportData()
        {
           _extractedData = _dataExtractorService.ExtractData(_createdDataObject,sqlTableName);
            return _extractedData;
        }

    }
}
