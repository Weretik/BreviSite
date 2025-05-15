using Domain.Entities;

namespace Application.Interfaces
{
    public interface IWalletRepository
    {
        Task<List<Wallet>> GetAllWalletsAsync();
        Task<Wallet?> GetWalletByIdAsync(int id);
        Task AddWalletAsync(Wallet wallet);
        Task UpdateWalletAsync(Wallet wallet);
        Task DeleteWalletAsync(Wallet wallet);
    }
}
