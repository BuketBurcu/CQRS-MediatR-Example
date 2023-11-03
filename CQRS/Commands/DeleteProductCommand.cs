using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSExample.CQRS.Commands
{
    public class DeleteProductCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
