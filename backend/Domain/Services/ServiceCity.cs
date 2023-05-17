using Domain.Interfaces;
using Domain.Interfaces.ServicesInterfaces;
using Entidades.Entidades;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceCity : ICityService
    {

        private readonly ICity _ICity;

        public ServiceCity(ICity ICity)
        {
            _ICity = ICity;
        }
        public async Task CreateCity(City city)
        {
            var validateCityName = city.ValidatePropertyString(city.CityName, "CityName");
            var validateStateId = city.ValidatePropertyString(city.StateId, "StateId");

            if (validateCityName && validateStateId)
            {
                city.CreatedAt = DateTime.Now;
                city.UpdatedAt = DateTime.Now;

                await _ICity.Create(city);
            }
        }

        public async Task<List<City>> ListCity()
        {
            return await _ICity.List();
        }

        public async Task UpdateCity(City city)
        {
            var validateCityName = city.ValidatePropertyString(city.CityName, "CityName");
            var validateStateId = city.ValidatePropertyString(city.StateId, "StateId");

            if (validateCityName && validateStateId)
            {
                city.CreatedAt = DateTime.Now;
                city.UpdatedAt = DateTime.Now;

                await _ICity.Update(city);
            }
        }
    }
}
