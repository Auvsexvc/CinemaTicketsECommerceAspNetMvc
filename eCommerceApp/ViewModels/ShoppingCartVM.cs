﻿using eCommerceApp.Data.Cart;

namespace eCommerceApp.ViewModels
{
    public class ShoppingCartVM
    {
        public ShoppingCart ShoppingCart { get; set; } = null!;
        public double ShoppingCartTotal { get; set; }
    }
}