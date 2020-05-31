using CQRSAndMediator.RequestModels.QueryRequestModels;
using CQRSAndMediator.ResponseModels.QueryResponseModels;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSAndMediator.Handlers.QueryHandlers
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdRequestModel, GetOrderByIdResponseModel>
    {
        public async Task<GetOrderByIdResponseModel> Handle(GetOrderByIdRequestModel request, CancellationToken cancellationToken)
        {
            var orderDetails = new GetOrderByIdResponseModel();

            return orderDetails;
        }

        //public GetOrderByIdResponseModel GetOrderById(GetOrderByIdRequestModel requestModel)
        //{
        //    var orderDetails = new GetOrderByIdResponseModel();

        //    return orderDetails;
        //}
    }
}
