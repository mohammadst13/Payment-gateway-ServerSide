﻿using Microsoft.EntityFrameworkCore;
using MadPay724.Data.Repositories.Repo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace MadPay724.Data.Infrastructure
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
    {
        UserRepository UserRepository { get; }
        void Save();
        Task<int> SaveAsync();

    }
}