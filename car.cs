using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSale.Model
{
    public class car
    {
        public int id {get; set; }
        public string Brand { get; set; }

        public string Type { get; set; }

        public string License { get; set; }
        public string Date { get; set; }

        internal void Add(car car)
        {
            throw new NotImplementedException();
        }
    }
}
