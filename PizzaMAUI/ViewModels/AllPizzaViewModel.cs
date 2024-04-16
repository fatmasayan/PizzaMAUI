﻿namespace PizzaMAUI.ViewModels
{

    [QueryProperty(nameof(FromSearch), nameof(FromSearch))]
    public partial class AllPizzaViewModel : ObservableObject
    {
        private readonly PizzaService _pizzaService;
        public AllPizzaViewModel(PizzaService pizzaService)
        {
            _pizzaService = pizzaService;
            Pizzas =new(_pizzaService.GetALlPizzaas());
        }


        public ObservableCollection<Pizza> Pizzas { get; set; }

        [ObservableProperty]
        private bool _fromSearch;

        [ObservableProperty]
        private bool _searching;

        [RelayCommand]
        private async Task SearchPizzas(string searchTerm)
        {
            Pizzas.Clear();
            Searching = true;
            await Task.Delay(1000);
            foreach (var pizza in _pizzaService.SearchPizzas(searchTerm))
            {
                Pizzas.Add(pizza);
            }

            Searching = false;
            var pizzas = _pizzaService.SearchPizzas(searchTerm);
        }

    }
}


