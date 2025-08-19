using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Repositories.Order
{
    public interface IOrderWriteOnlyRepository
    {
        Task Add(Entities.Order order);
    }
}
