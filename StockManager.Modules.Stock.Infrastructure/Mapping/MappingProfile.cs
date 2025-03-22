using AutoMapper;
using StockManager.Modules.Stock.BO.Models;
using StockManager.Modules.Stock.Infrastructure.Entity;

namespace StockManager.Modules.Stock.Infrastructure.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<CustormerModel, CustomerEntity>().ReverseMap();
        }
    }
}
