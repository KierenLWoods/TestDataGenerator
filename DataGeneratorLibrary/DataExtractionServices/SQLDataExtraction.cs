using DataGeneratorLibrary.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGeneratorLibrary.DataExtractionServices
{
    public class SQLDataExtraction
    {
        List<CreatedDataObject> _testData;
        List<SQLObject> _objects;
        public SQLDataExtraction(List<CreatedDataObject> testData)
        {
            _testData = testData;
        }
        public List<SQLObject> CreateSQLData(string tableName)
        {
            _objects = new List<SQLObject>();
            foreach (var item in _testData)
            {
                List<string> columnList = new List<string>();
                List<string> columnValueList = new List<string>();
                foreach(var prop in item.Properties)
                {
                    columnList.Add(prop.ColumnName);
                    columnValueList.Add(prop.Value);

                }
                _objects.Add(new SQLObject { InsertQuery = $"insert into {tableName} ({String.Join(",",columnList)}) values ({String.Join(",", columnValueList)});" });
            }
            return _objects;
        }
    }
}
