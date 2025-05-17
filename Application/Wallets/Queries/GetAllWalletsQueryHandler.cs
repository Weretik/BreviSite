using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Wallets.Queries
{
    public class GetAllWalletsQueryHandler (IWalletRepository walletRepository, IMapper mapper)
        : IRequestHandler<GetAllWalletsQuery, List<WalletDto>>
    {
        private readonly IWalletRepository _walletRepository = walletRepository;
        private readonly IMapper _mapper = mapper;

        public async Task<List<WalletDto>> Handle(GetAllWalletsQuery request, CancellationToken cancellationToken)
        {
            var wallets = await _walletRepository.GetAllWalletsAsync();
            return _mapper.Map<List<WalletDto>>(wallets);
        }
    }
}
