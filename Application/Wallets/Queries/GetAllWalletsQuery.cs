using Application.DTOs;
using MediatR;

namespace Application.Wallets.Queries
{
    public record GetAllWalletsQuery : IRequest<List<WalletDto>>;

}
