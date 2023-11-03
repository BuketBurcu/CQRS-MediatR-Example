using CQRSExample.CQRS.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSExample.CQRS.Handlers.CommandHandlers
{
    public class UpdateProductCommandHandle : IRequestHandler<UpdateProductCommand, int>
    {
        public Task<int> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(request.Id);
            //Repository'ye gidip db'den güncelleme işlemi gerçekleştirmeli
        }
    }
}
