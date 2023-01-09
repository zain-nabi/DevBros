using Bikes.Interface;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bikes.Repository
{
    public class BikeRepository : IBike
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public BikeRepository(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<Model.Bikes> FindByID(int BikeID)
        {
            List<Model.Bikes> items = new List<Model.Bikes>();
            var rootPath = _hostingEnvironment.ContentRootPath;
            var fullPath = Path.Combine(rootPath, "Json/bikes_response.json"); 
            using (StreamReader r = new StreamReader(fullPath))
            {
                string json = await r.ReadToEndAsync();
                items = JsonConvert.DeserializeObject<List<Model.Bikes>>(json);
            }
            var bike = (from b in items
                       where b.BikeID == BikeID
                       select new Model.Bikes()
                       {
                           BikeID = b.BikeID,
                           Make = b.Make,
                           Model = b.Model,
                           Year = b.Year,
                           Displacement = b.Displacement,
                           Price = b.Price,
                           Terrain = b.Terrain,
                           Description = b.Description

                       }).FirstOrDefault();

            return bike;
        }

        public async Task<List<Model.Bikes>> GetAllAsync()
        {
            List<Model.Bikes> items = new List<Model.Bikes>();
            var rootPath = _hostingEnvironment.ContentRootPath;
            var fullPath = Path.Combine(rootPath, "Json/bikes_response.json");

            using (StreamReader r = new StreamReader(fullPath))
            {
                string json = await r.ReadToEndAsync();
                items = JsonConvert.DeserializeObject<List<Model.Bikes>>(json);
            }
            return items;
        }
    }
}
