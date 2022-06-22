using DataGeneratorLibrary.DataModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGeneratorLibrary
{
    public class SurnameFileReader
    {
        private static SurnameFileReader _instance;
        public  List<Surnames> Surnames;
        public SurnameFileReader()
        {
            Surnames = GetSurnamesFromFile();   
        }
        public static SurnameFileReader GetSurnameFileReader()
        {
            if(_instance == null)
            {
                _instance = new SurnameFileReader();
            }
            return _instance;
        }
        public  List<Surnames> GetSurnamesFromFile()
        {
            string line;
            List<Surnames> surnames= new List<Surnames>();
            var filePath = Environment.CurrentDirectory.ToString(); 
            System.IO.StreamReader file =
                new System.IO.StreamReader(filePath + "\\Surnames.txt");
            while ((line = file.ReadLine()) != null)
            {
                
                surnames.Add(new Surnames { Surname = line});
            }

            file.Close();
            return surnames;
        }
    }
}
