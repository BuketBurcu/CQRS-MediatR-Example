using CQRSExample.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSExample.CQRS.Queries
{
    public class GetAllProductQueryRequest : IRequest<IEnumerable<GetProductByIdModelResponse>>
    {
    }
}
