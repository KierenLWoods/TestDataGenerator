using DataGeneratorLibrary.DataModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGeneratorLibrary.DataExtractionServices
{
    public class JsonDataExtraction
    {
       

        public List<JsonObject> CreateJsonObject(List<CreatedDataObject> createdDataObjects)
        {
            List<JsonObject> jsonObject = new List<JsonObject> { new JsonObject { JSONString = JsonConvert.SerializeObject(createdDataObjects) } };
            return jsonObject;
        }
    }
}
