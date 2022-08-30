using AutoMapper;
using MediatR;
using MediatRCqrs.DTO_s;
using MediatRCqrs.Entities;
using MediatRCqrs.Repositories;

namespace MediatRCqrs.MedHandlers.Commands
{
    public class CreateProductCommand : IRequest<CreateResponseDto>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateResponseDto>
        {
            IProductRepository productrepository;
            IMapper mapper;

            public CreateProductCommandHandler(IProductRepository productrepository, IMapper mapper)
            {
                this.productrepository = productrepository;
                this.mapper = mapper;
            }

            public Task<CreateResponseDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                var product = mapper.Map<Product>(request);
                var product2 = productrepository.Add(product);
                var idDon =  mapper.Map<CreateResponseDto>(product2);
                return Task.FromResult(idDon);
            }
        }
    }
}
