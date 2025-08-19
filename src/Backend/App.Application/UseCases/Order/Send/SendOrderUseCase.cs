using App.Communication.Requests;
using App.Communication.Responses;
using App.Domain.Repositories;
using App.Domain.Repositories.Order;
using App.Domain.Repositories.Product;
using App.Domain.Services.MessageQueue;
using AutoMapper;

namespace App.Application.UseCases.Order.Send
{
    public class SendOrderUseCase : ISendOrderUseCase
    {
        private readonly IMapper _mapper;
        private readonly IOrderWriteOnlyRepository _writeOnlyRepository;
        private readonly IUnitOfWork _commit;
        private readonly IKafkaMessageService _kafkaMessageService;

        public SendOrderUseCase(
            IMapper mapper,
            IOrderWriteOnlyRepository writeOnlyRepository,
            IUnitOfWork commit,
            IKafkaMessageService kafkaMessage)
        {
            _mapper = mapper;
            _writeOnlyRepository = writeOnlyRepository;
            _commit = commit;
            _kafkaMessageService = kafkaMessage;
        }

        public async Task<ResponseOrdersJson> Execute(RequestOrdersJson request)
        {
            var order = _mapper.Map<Domain.Entities.Order>(request);

            await _writeOnlyRepository.Add(order);

            await _kafkaMessageService.SendMessage(order);

            await _commit.Commit();

            return new ResponseOrdersJson
            {
                CustomerName = order.CustomerName,
                OrderDate = order.OrderDate,
                Status = order.Status,
            };
        }
    }
}
