using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSExample.Models
{
    public class GetProductByIdModelResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
