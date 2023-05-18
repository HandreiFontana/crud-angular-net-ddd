using Application.Interfaces;
using Domain.Interfaces;
using Domain.Interfaces.ServicesInterfaces;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Applications
{
    public class StateApplication : IStateApplication
    {

        IState _IState;
        IStateService _IStateService;

        public StateApplication(IState IState, IStateService IStateService) 
        {
            _IState = IState;
            _IStateService = IStateService;
        }

        public async Task CreateState(State state)
        {
            await _IStateService.CreateState(state);
        }

        public async Task<List<State>> ListState()
        {
            return await _IStateService.ListState();
        }

        public async Task UpdateState(State state)
        {
            await _IStateService.UpdateState(state);
        }

        public async Task Create(State Object)
        {
            await _IState.Create(Object);
        }

        public async Task Delete(State Object)
        {
            await _IState.Delete(Object);
        }

        public async Task<State> Get(int Id)
        {
            return await _IState.Get(Id);
        }

        public async Task<List<State>> List()
        {
            return await _IState.List();
        }

        public async Task Update(State Object)
        {
            await _IState.Update(Object);
        }
    }
}
