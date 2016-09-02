using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;
using System.IO;

namespace ReplaserCSV
{
    public class Program
    {
        static void Main(string[] args)
        {
            String[] names = new String[] { "tr", "ua", "kz", "by", "md" };
            foreach (var item in names)
            {
                String[] strings = File.ReadAllLines(@"D:\TEST\csv\" + item + ".csv");
                String[] jsonstr = File.ReadAllLines(@"D:\TEST\csv\" + item + ".json");
                foreach (var strn in strings)
                {
                    var mass = strn.Split(';');
                    var unit = mass[0];
                    var date = mass[1];
                    var source = mass[2];
                    var str = jsonstr.First(e => e.Contains("unnntt"));
                    var index = Array.IndexOf(jsonstr, str);
                    str = str.Replace("unnntt", unit);
                    jsonstr[index] = str;
                    var str1 = jsonstr.First(e => e.Contains("reeelleevnc"));
                    var index1 = Array.IndexOf(jsonstr, str1);
                    str1 = str1.Replace("reeelleevnc", date);
                    jsonstr[index1] = str1;
                    var str2 = jsonstr.First(e => e.Contains("souuurc"));
                    var index2 = Array.IndexOf(jsonstr, str2);
                    str2 = str2.Replace("souuurc", source);
                    jsonstr[index2] = str2;
                }
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\TEST\csv\result\" + item + ".json"))
                {
                    foreach (var str in jsonstr)
                    {
                        file.Write(str);
                    }
                }
            }
        }
    }
}

