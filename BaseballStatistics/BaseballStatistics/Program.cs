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
            List<double> baseballstatistics = new List<double>();
            baseballstatistics.Add(.361);
            baseballstatistics.Add(.346);
            baseballstatistics.Add(.540);

            List<string> baseballstatisticnames = new List<string>();
            baseballstatisticnames.Add("Jose Altuve");
            baseballstatisticnames.Add("Daniel Murphy");
            baseballstatisticnames.Add("Edwin Encarnacion");

            for (int i=0; i<baseballstatistics.Count; i++)
            {
                Console.WriteLine(baseballstatisticnames[i]+ " " + baseballstatistics[i]);   
            }
            Console.ReadLine();
        }

       }
}

