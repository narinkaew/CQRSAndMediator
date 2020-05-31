using CQRSAndMediator.ResponseModels.QueryResponseModels;
using MediatR;
using System;

namespace CQRSAndMediator.RequestModels.QueryRequestModels
{
    public class GetOrderByIdRequestModel : IRequest<GetOrderByIdResponseModel>
    {
        public Guid OrderId { get; set; }
    }
}
