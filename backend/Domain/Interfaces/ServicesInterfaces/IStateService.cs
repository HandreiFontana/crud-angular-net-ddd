using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.ServicesInterfaces
{
    public interface IStateService
    {
        Task CreateState(State state);

        Task UpdateState(State state);

        Task<List<State>> ListState();
    }
}
