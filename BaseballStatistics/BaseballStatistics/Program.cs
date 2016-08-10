using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> baseballstatistics = new List<int>();
            baseballstatistics.Add(6);
            baseballstatistics.Add(7);
            baseballstatistics.Add(8);

            List<string> baseballstatisticnames = new List<string>();
            baseballstatisticnames.Add("John");
            baseballstatisticnames.Add("Roger");
            baseballstatisticnames.Add("Gina");

            for (int i=0; i<baseballstatistics.Count; i++)
            {
                Console.WriteLine(baseballstatisticnames[i]+ " " + baseballstatistics[i]);   
            }
            Console.ReadLine();
        }

       }
}

