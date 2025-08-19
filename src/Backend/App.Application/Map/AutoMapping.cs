using App.Communication.Requests;
using App.Communication.Responses;
using App.Domain.Entities;
using AutoMapper;

namespace App.Application.Map
{
    public class AutoMapping : Profile
    {
        public AutoMapping() 
        {
            RequestToDomain();
            DomainToRequest();
        }

        private void RequestToDomain()
        {
            CreateMap<RequestProductJson, Product>();
            CreateMap<RequestOrdersJson, Order>();
            CreateMap<RequestOrderItemJson, OrderItem>();
        }

        private void DomainToRequest()
        {
            CreateMap<Product, ResponseProductJson>();
            CreateMap<Order, ResponseOrdersJson>();
            CreateMap<OrderItem, ResponseOrderItemJson>();
        }
    }
}
