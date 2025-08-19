using App.Domain.Entities;
using App.Domain.Repositories.Order;
using App.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Repositories
{
    public class OrderRepository : IOrderWriteOnlyRepository
    {
        private readonly ProductAppDbContext _dbContext;

        public OrderRepository(ProductAppDbContext dbContext) => _dbContext = dbContext;
        public async Task Add(Order order) => await _dbContext.Orders.AddAsync(order);
    }
}
