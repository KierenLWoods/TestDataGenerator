using DataGeneratorLibrary.DataExtractionServices;
using DataGeneratorLibrary.DataModels;
using DataGeneratorLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGeneratorLibrary.Services
{
    public class DataExtractorService
    {
        private List<CreatedDataObject> _testData;
        private DataExportEnums _dataExportMethod;
        List<IBaseExtractionData> returnDataList = new List<IBaseExtractionData>();
        public DataExtractorService(List<CreatedDataObject> testData,DataExportEnums dataExport)
        {
            _testData = testData;
            _dataExportMethod = dataExport;
        }
        private static DataExtractorService _instance;
        public static DataExtractorService GetDataExtractorService(List<CreatedDataObject> testData,DataExportEnums dataExport)
        {
            if (_instance == null)
            {
                _instance = new DataExtractorService(testData,dataExport);
            }
            return _instance;
        }

        //Purpose of this method is to export the data as per the selected enum , so if SQL will return Concrete ExtractionObject
        public List<IBaseExtractionData> ExtractData(List<CreatedDataObject> testData,string tableName)
        {
             
            switch (_dataExportMethod)
            {
                case (DataExportEnums.Sql):
                    {
                        SQLDataExtraction sql = new SQLDataExtraction(testData);
                      returnDataList.AddRange(sql.CreateSQLData(tableName));
                        break;
                    }
                    case (DataExportEnums.Json):
                    {
                        JsonDataExtraction json = new JsonDataExtraction();
                        returnDataList.AddRange(json.CreateJsonObject(testData));
                        break;
                    }
            }
            return returnDataList;
        }
    }
}
