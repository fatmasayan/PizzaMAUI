namespace PizzaMAUI.Services;

public class PizzaService
{
    private readonly static IEnumerable<Pizza> pizzaas = new List<Pizza>
    {
        new Pizza
        {
        Name = "Pizza 1",
        Image = "pizza1.png",
        Price = 10.0
    },

    new Pizza
    {
        Name = "Pizza 2",
        Image = "pizza2.png",
        Price = 20.0
    },

    new Pizza
    {
        Name = "Pizza 3",
        Image = "pizza3.png",
        Price = 30.0
    },

    new Pizza
    {
        Name = "Pizza 4",
        Image = "pizza4.png",
        Price = 40.0
    },

    new Pizza
    {
        Name = "Pizza 5",
        Image = "pizza5.png",
        Price = 50.0
    },

    new Pizza
    {
        Name = "Pizza 6",
        Image = "pizza6.png",
        Price = 60.0
    },

    new Pizza
    {
        Name = "Pizza 7",
        Image = "pizzaa.png",
        Price = 70.0
    }
    };

    public IEnumerable<Pizza> GetALlPizzaas() => pizzaas;
    public IEnumerable<Pizza> GetPopularPizzas(int count = 6) => pizzaas.OrderBy(p => Guid.NewGuid()).Take(count);
    public IEnumerable<Pizza> SearchPizzas(string searchTerm) =>
        string.IsNullOrEmpty(searchTerm)
        ? pizzaas
        : pizzaas.Where(p => p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));


}
