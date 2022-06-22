using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGeneratorLibrary.DataModels
{
    public class SQLObject:IBaseExtractionData
    {
        [DisplayName("SQLQuery")]
        public string InsertQuery { get; set; }
    }
}
