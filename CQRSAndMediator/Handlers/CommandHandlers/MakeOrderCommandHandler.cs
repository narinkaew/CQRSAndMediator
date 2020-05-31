using CQRSAndMediator.RequestModels.CommandRequestModels;
using CQRSAndMediator.ResponseModels.CommandResponseModels;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSAndMediator.Handlers.CommandHandlers
{
    public class MakeOrderCommandHandler : IRequestHandler<MakeOrderRequestModel, MakeOrderResponseModel>
    {
        public async Task<MakeOrderResponseModel> Handle(MakeOrderRequestModel request, CancellationToken cancellationToken)
        {
            var result = new MakeOrderResponseModel
            {
                IsSuccess = true,
                OrderId = Guid.NewGuid()
            };

            return result;
        }

        //public MakeOrderResponseModel MakeOrder(MakeOrderRequestModel requestModel)
        //{
        //    var result = new MakeOrderResponseModel
        //    {
        //        IsSuccess = true,
        //        OrderId = new Guid()
        //    };

        //    return result;
        //}
    }
}
