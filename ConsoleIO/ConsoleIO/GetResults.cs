using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIO.GetCSV
{
    class GetResults
    {
        public DateTime GameDate { get; set; }
        public string TeamName { get; set; }
        public HomeAway HomeOrAway { get; set; }

        public enum HomeAway
        {
            Home, 
            Away
        }
    }
}
