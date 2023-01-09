using Bikes.Interface;
using Bikes.Model;
using DevBrosBikers.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBrosBikers.Controllers
{
    public class BikesController : Controller
    {
        private readonly IBike bike;

        public BikesController(IBike _bike)
        {
            bike = _bike;
        }

        [HttpGet]
        public async Task<ActionResult> Currentbikes()
        {
            var bikes = new BikesModel();
            bikes.BikeList = new List<Bikes.Model.Bikes>();
            foreach (var item in await bike.GetAllAsync())
            {
                bikes.BikeList.Add(new Bikes.Model.Bikes()
                {
                    BikeID = item.BikeID,
                    Make = item.Make,
                    Model = item.Model,
                    Year = item.Year,
                    Displacement = item.Displacement,
                    Price = item.Price,
                    Terrain = item.Terrain,
                    Description = item.Description
                });
            }
            return View(bikes.BikeList);
        }

        [HttpGet]
        public async Task<ActionResult> Bikedetail(int BikeID)
        {
            var bikes = new BikesModel();
            bikes.Bikes = new Bikes.Model.Bikes();
            bikes.Bikes = await bike.FindByID(BikeID);
            return View(bikes.Bikes);
        }
    }
}
