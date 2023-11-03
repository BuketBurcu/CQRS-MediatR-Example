using CQRSExample.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSExample.Queries
{
    public class GetProductByIdQueryRequest : IRequest<GetProductByIdModelResponse>
    {
        public Guid Id { get; set; }
    }
}
