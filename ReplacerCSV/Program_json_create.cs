using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;
using System.IO;
using ReplacerCSV;
using Newtonsoft.Json;

namespace ReplaserCSV
{
    public class Program
    {
        static void Main(string[] args)
        {
            String[] strings = File.ReadAllLines(@"D:\cat.csv");
            CatCollection myCollection = new CatCollection();
            myCollection.Indicators = new Indicator[20];
            var i = 0;
            foreach (var strn in strings)
            {
                var mass = strn.Split(';');

                myCollection.Indicators[i] = new Indicator()
                {
                    id = mass[0],
                    name = mass[1],
                    category_ids = new CategoryIdEn()
                    {
                        GBR = mass[7],
                        USA = mass[8],
                        CAN = mass[9],
                    }
                };

                i++;

                string serialized = JsonConvert.SerializeObject(myCollection);

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\catEn.json"))
                {
                    file.Write(serialized);
                }
            }
        }
    }
}

