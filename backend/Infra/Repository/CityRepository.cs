using Domain.Interfaces;
using Entidades.Entidades;
using Infra.Repository.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class CityRepository : GenericRepository<City>, ICity
    {
    }
}
