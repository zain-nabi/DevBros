using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bikes.Model;

namespace DevBrosBikers.Models
{
    public class BikesModel
    {
        public Bikes.Model.Bikes Bikes { get; set; }
        public List<Bikes.Model.Bikes> BikeList { get; set; }
    }
}
