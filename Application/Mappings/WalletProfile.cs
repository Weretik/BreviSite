using Application.DTOs;
using AutoMapper;
using Domain.Entities;


namespace Application.Mappings
{
    public class WalletProfile : Profile
    {
        public WalletProfile()
        {
            CreateMap<Wallet, WalletDto>();
        }
    }
}
