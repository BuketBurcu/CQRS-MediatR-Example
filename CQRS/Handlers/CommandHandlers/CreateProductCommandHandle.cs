using CQRSExample.CQRS.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSExample.Handlers.CommandHandlers
{
    public class CreateProductCommandHandle : IRequestHandler<CreateProductCommand, Guid>
    {
        public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Guid.NewGuid());
            // reopsitory aracılığıyla veritabanına gönderilir.
        }
    }
}
