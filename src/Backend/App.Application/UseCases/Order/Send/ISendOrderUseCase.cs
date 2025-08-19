using App.Communication.Requests;
using App.Communication.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.UseCases.Order.Send
{
    public interface ISendOrderUseCase
    {
        Task<ResponseOrdersJson> Execute(RequestOrdersJson request);
    }
}
