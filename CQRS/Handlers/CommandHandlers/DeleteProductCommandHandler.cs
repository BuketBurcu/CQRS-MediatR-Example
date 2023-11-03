using CQRSExample.CQRS.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSExample.CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, int>
    {
        public Task<int> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(request.Id);
            //Repository'ye gidip db'den silme işlemi gerçekleştirmeli
        }
    }
}
