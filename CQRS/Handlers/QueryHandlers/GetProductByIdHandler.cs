using CQRSExample.Models;
using CQRSExample.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSExample.Handlers.QueryHandlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQueryRequest, GetProductByIdModelResponse>
    {
        public Task<GetProductByIdModelResponse> Handle(GetProductByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var viewModel = new GetProductByIdModelResponse()
            {
                Id = Guid.NewGuid(),
                Name = "book"
            };
            return Task.FromResult(viewModel);
        }
    }
}
