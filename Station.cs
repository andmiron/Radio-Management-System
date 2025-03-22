using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicUtilities
{
    internal class Station
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public decimal Frequency { get; set; }
        public required string Name { get; set; }
    }
}
