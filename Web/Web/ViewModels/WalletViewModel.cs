﻿namespace Web.ViewModels
{
    public class WalletViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Balance { get; set; }
        public string? Notes { get; set; }
    }
}
