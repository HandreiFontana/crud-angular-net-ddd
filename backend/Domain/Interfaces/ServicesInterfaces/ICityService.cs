using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.ServicesInterfaces
{
    public interface ICityService
    {
        Task CreateCity(City city);

        Task UpdateCity(City city);

        Task<List<City>> ListCity();
    }
}
