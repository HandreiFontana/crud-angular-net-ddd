using Application.Interfaces.Generics;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICityApplication : IApplicationGeneric<City>
    {
        Task CreateCity(City city);

        Task UpdateCity(City city);

        Task<List<City>> ListCity();
    }
}
