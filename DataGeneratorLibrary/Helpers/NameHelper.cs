using DataGeneratorLibrary.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGeneratorLibrary.Helpers
{

    public class NameHelper<T> where T : IName,new ()
    {
        public List<T> _nameObjectList;

        public List<T> GetNamesFromFile(string nameFile)
        {
            string line;
            List<T> namesList = new List<T>();
            var filePath = Environment.CurrentDirectory.ToString();
            System.IO.StreamReader file =
                new System.IO.StreamReader(filePath + nameFile);
            while ((line = file.ReadLine()) != null)
            {

                namesList.Add(new T { Name = line });
            }

            file.Close();
            return namesList;
        }
    }
}
