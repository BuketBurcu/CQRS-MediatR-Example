using CQRSExample.CQRS.Queries;
using CQRSExample.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSExample.CQRS.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, IEnumerable<GetProductByIdModelResponse>>
    {
        public Task<IEnumerable<GetProductByIdModelResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
