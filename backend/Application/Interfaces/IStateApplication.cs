using Application.Interfaces.Generics;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IStateApplication : IApplicationGeneric<State>
    {
        Task CreateState(State state);

        Task UpdateState(State state);

        Task<List<State>> ListState();
    }
}
