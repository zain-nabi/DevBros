using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bikes.Model
{
    public class BikesViewModel
    {
        public List<Bikes> Bikes { get; set; }
    }

    public class Bikes
    {
        public int BikeID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Displacement { get; set; }
        public int Price { get; set; }
        public string Terrain { get; set; }
        public string Description { get; set; }
    }
}
