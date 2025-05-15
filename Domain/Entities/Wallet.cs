using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Wallet : BaseEntity<int>
    {
        public string WalletName { get; private set; } = string.Empty;
        public decimal Balance { get; private set; }
        public string? Note { get; private set; }

        public Wallet(string walletName, decimal balance)
        {
            if (string.IsNullOrWhiteSpace(walletName))
                throw new ArgumentException("Wallet name cannot be empty.", nameof(walletName));
            if (balance < 0)
                throw new ArgumentOutOfRangeException(nameof(balance), "Balance cannot be negative.");

            WalletName = walletName;
            Balance = balance;
        }

        public void ChangeWalletName(string newWalletName)
        {
            if (string.IsNullOrWhiteSpace(newWalletName))
                throw new ArgumentException("New wallet name cannot be empty.", nameof(newWalletName));
            WalletName = newWalletName;
            MarkAsUpdated();
        }
        public void UpdateBalance(decimal newBalance)
        {
            if (newBalance < 0)
                throw new ArgumentOutOfRangeException(nameof(newBalance), "New balance cannot be negative.");
            Balance = newBalance;
            MarkAsUpdated();
        }
        public void UpdateNote(string newNote)
        {
            Note = newNote;
            MarkAsUpdated();
        }
    }
}
