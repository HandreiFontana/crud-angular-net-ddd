using Domain.Interfaces.ServicesInterfaces;
using Domain.Interfaces;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Application.Applications
{
    public class CityApplication : ICityApplication
    {
        ICity _ICity;
        ICityService _ICityService;

        public CityApplication(ICity ICity, ICityService ICityService)
        {
            _ICity = ICity;
            _ICityService = ICityService;
        }

        public async Task CreateCity(City city)
        {
            await _ICityService.CreateCity(city);
        }

        public async Task<List<City>> ListCity()
        {
            return await _ICityService.ListCity();
        }

        public async Task UpdateCity(City city)
        {
            await _ICityService.UpdateCity(city);
        }

        public async Task Create(City Object)
        {
            await _ICity.Create(Object);
        }

        public async Task Delete(City Object)
        {
            await _ICity.Delete(Object);
        }

        public async Task<City> Get(int Id)
        {
            return await _ICity.Get(Id);
        }

        public async Task<List<City>> List()
        {
            return await _ICity.List();
        }

        public async Task Update(City Object)
        {
            await _ICity.Update(Object);
        }
    }
}
