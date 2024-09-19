using System;
using DAL.Repositories;

namespace DAL.Interfaces
{
	public interface IUnitOfWork: IDisposable
    {
        Task SaveChangesAsync();
        IProductRepository Products { get; }

    }
}

