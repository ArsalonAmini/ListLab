using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseballstatisticsv2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Statistics> baseBall = new List<Statistics>{
            new Statistics{amount = 6.8, type="M.Trout"},
            new Statistics{amount = 6.7, type="J.Altuve"};
            new Statistics {amount = 5.6, type = "J.Donaldson"}; 
       class Statistics
        {
            public int amount { get; set; }
            public string type { get; set; }
        }

    }