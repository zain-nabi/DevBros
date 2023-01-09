using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bikes.Interface
{
    public interface IBike
    {
        Task<List<Bikes.Model.Bikes>> GetAllAsync();
        Task<Bikes.Model.Bikes> FindByID(int BikeID);
    }
}
