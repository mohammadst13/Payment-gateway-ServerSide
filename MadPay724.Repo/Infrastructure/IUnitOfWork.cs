using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using MadPay724.Repo.Repositories.Interface;

namespace MadPay724.Repo.Infrastructure
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
    {
        IUserRepository UserRepository { get; }
        void Save();
        Task<int> SaveAsync();

    }
}