using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGeneratorLibrary.DataModels
{
    public class CreatedDataObject
    {
        public List<CreatedDataPropertiesModel> Properties { get; set; } = new List<CreatedDataPropertiesModel>();
    }
}
