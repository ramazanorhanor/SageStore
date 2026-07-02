using AutoMapper;
using SageStore.Application.CQRS.SupplierManagement.Commands;
using SageStore.Domain.Entities;
namespace SageStore.Application.CQRS.SupplierManagement.Profiles
{
    public class SupplierProfile:Profile
    {
        public SupplierProfile() {
            CreateMap<CreateSupplierCommand, Supplier>();
        }    
    }
}
