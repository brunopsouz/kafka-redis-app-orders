using App.Application.UseCases.Order.Send;
using App.Communication.Requests;
using App.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ProductsBaseController
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseOrdersJson), StatusCodes.Status201Created)]
        public async Task<IActionResult> SendOrder(
            [FromServices] ISendOrderUseCase useCase,
            [FromBody] RequestOrdersJson request)
        {
            var result = await useCase.Execute(request);
            return Created(string.Empty, result);
        }


    }
}
