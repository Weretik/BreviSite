using Application.DTOs;
using AutoMapper;
using Web.ViewModels;

namespace Web.Mappings
{
    public class WalletViewModelProfile : Profile
    {
        public WalletViewModelProfile()
        {
            CreateMap<WalletDto, WalletViewModel>();
        }
    }
}
