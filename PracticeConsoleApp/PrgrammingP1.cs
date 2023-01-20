using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    public class PrgrammingP1
    {
        public static void Main()
        {
            string input = "helloo";
            string res = string.Empty;
            var map=new Dictionary<string, int>();
            for(int i = 0; i < input.Length; i++)
            {
                if (map.ContainsKey(input[i].ToString()))
                {
                    map[input[i].ToString()]++;
                }
                else
                {
                    map.Add(input[i].ToString(), 1);
                }
            }

            var res1 = map.Where(x => x.Value > 1).Select(x => x.Key).ToList();

            input.GroupBy(x=>x).ToDictionary(y=>new {key=y.Key,val=y.Count()}).Select(y=>y.Value).ToList();

            Console.WriteLine(res);
        }

    }
}



