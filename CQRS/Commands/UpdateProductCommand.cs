using MediatR;

namespace CQRSExample.CQRS.Commands
{
    public class UpdateProductCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Value { get; set; }
    }
}
