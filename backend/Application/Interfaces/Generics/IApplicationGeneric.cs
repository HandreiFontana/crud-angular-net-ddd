﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Generics
{
    public interface IApplicationGeneric<T> where T : class
    {
        Task Create(T Object);

        Task Update(T Object);

        Task Delete(T Object);

        Task<T> Get(int Id);

        Task<List<T>> List();
    }
}
