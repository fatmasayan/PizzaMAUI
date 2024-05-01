﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMAUI.ViewModels
{
    [QueryProperty(nameof(Pizza), nameof(Pizza))]

    public partial class DetailsViewModel : ObservableObject
    {
        public DetailsViewModel()
        {
            
        }

        [ObservableProperty]
        private Pizza _pizza;

        private void AddToCart()
        {
            Pizza.CartQuantity++;

        }

        [RelayCommand]
        private void RemoveFromCart()
        {
            if (Pizza.CartQuantity > 0)
                Pizza.CartQuantity--;


        }

    }
}
