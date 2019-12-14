using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Data
{
    public class General
    {
        public List<string> loadCsvFile(string Top)
        {
            var reader = new StreamReader(File.OpenRead(@"C:\Users\e140621\Desktop\TodoApi\TodoApiv\Top.csv"));
            List<string> searchList = new List<string>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                searchList.Add(line);
            }

            return searchList;
        }
    }
}