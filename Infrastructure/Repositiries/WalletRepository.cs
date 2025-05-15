using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositiries
{
    public class WalletRepository(BreviDBContext context) : IWalletRepository
    {
        private readonly BreviDBContext _context = context;

        public async Task<List<Wallet>> GetAllWalletsAsync()
            => await _context.Wallets.ToListAsync();
        public async Task<Wallet?> GetWalletByIdAsync(int id)
            => await _context.Wallets.FindAsync(id);
        public async Task AddWalletAsync(Wallet wallet)
            => await _context.Wallets.AddAsync(wallet);
        public Task UpdateWalletAsync(Wallet wallet)
        {
            wallet.MarkAsUpdated();
            _context.Wallets.Update(wallet);
            return Task.CompletedTask;
        }
        public Task DeleteWalletAsync(Wallet wallet)
        {
            wallet.SoftDeleted();
            _context.Wallets.Update(wallet);
            return Task.CompletedTask;
        }


    }
}
