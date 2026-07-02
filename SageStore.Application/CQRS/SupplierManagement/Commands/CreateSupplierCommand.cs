using AutoMapper;
using MediatR;
using SageStore.Domain.Entities;
using SageStore.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SageStore.Application.CQRS.SupplierManagement.Commands
{
    public class CreateSupplierCommand:IRequest
    {
        // dto 
        public string TaxNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Address { get; set; }
    }
    public class CreateSupplierCommandHandler(StoreContext context,IMapper mapper) : IRequestHandler<CreateSupplierCommand>
    {
        // insert update delete 
        public async Task Handle(CreateSupplierCommand request, CancellationToken cancellationToken)
        {
            var supplier = mapper.Map<Supplier>(request);
            context.Suppliers.Add(supplier);
            await context.SaveChangesAsync(cancellationToken);
        }
    }
}
