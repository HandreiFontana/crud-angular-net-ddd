using Domain.Interfaces;
using Domain.Interfaces.ServicesInterfaces;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceState : IStateService
    {

        private readonly IState _IState;

        public ServiceState(IState IState)
        {
            _IState = IState;
        }

        public async Task CreateState(State state)
        {
            var validateStateName = state.ValidatePropertyString(state.StateName, "StateName");
            var validateFederativeUnit = state.ValidatePropertyString(state.FederativeUnit, "FederativeUnit");

            if (validateStateName && validateFederativeUnit)
            {
                state.CreatedAt = DateTime.Now;
                state.UpdatedAt = DateTime.Now;

                await _IState.Create(state);
            }
        }

        public async Task<List<State>> ListState()
        {
            return await _IState.List();
        }

        public async Task UpdateState(State state)
        {
            var validateStateName = state.ValidatePropertyString(state.StateName, "StateName");
            var validateFederativeUnit = state.ValidatePropertyString(state.FederativeUnit, "FederativeUnit");

            if (validateStateName && validateFederativeUnit)
            {
                state.CreatedAt = DateTime.Now;
                state.UpdatedAt = DateTime.Now;

                await _IState.Update(state);
            }
        }
    }
}
