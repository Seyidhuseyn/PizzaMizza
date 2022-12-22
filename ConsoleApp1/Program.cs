using ConsoleApp1.Models;
using ConsoleApp1.Services;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------PizzaService Hissesi---------------------------------------------------

            PizzaService pizzaService = new PizzaService();
            //pizzaService.CreatePizza("Chicken", 12.25d);

            //List<Pizza> pizzas = pizzaService.GetAll();
            //foreach (Pizza pizza in pizzas)
            //{
            //    Console.WriteLine(pizza.Name);
            //}

            //Pizza pizza = pizzaService.GetById(1);
            //if (pizza == null)
            //{
            //    Console.WriteLine("Bele Pizza Yoxdur!");
            //}
            //foreach (Size size in pizza.Sizes)
            //{
            //    Console.WriteLine(size.Name);
            //}

            //pizzaService.Remove(1);

            //Size size = pizzaService.GetSizeById(1);

            //Console.WriteLine(size.Name);

            //------------------------------------------IngredientService Hissesi----------------------------------------------

            IngredientService ingredientService = new IngredientService();
            //ingredientService.CreateIngredient("Sous");

            //List<Ingredient> ingredients = ingredientService.GetAll();
            //foreach (Ingredient ingredient in ingredients)
            //{
            //    Console.WriteLine(ingredient.Name);
            //}

            //Ingredient ingredient = ingredientService.GetById(1);
            //if (ingredient == null)
            //{
            //    Console.WriteLine("Bele Ingredient Yoxdur!");
            //}
            //foreach (Ingredient ingredient in ingredient.Sizes)
            //{
            //    Console.WriteLine(ingredient.Name);
            //}

            //ingredientService.Remove(1);

            //Size ingredient = pizzaService.GetSizeById(1);

            //Console.WriteLine(ingredient.Name);


            //------------------------------------------SizeService Hissesi--------------------------------------------------

            SizeService sizeService = new SizeService();
            //sizeService.CreateSize("Chicken", 1);

            //List<Size> sizes = sizeService.GetAll();
            //foreach (Size size in sizes)
            //{
            //    Console.WriteLine(size.Name);
            //}

            //Size pizza = sizeService.GetById(1);
            //if (pizza == null)
            //{
            //    Console.WriteLine("Bele Size Yoxdur!");
            //}
            //foreach (Size size in size.Sizes)
            //{
            //    Console.WriteLine(size.Name);
            //}

            //sizeService.Remove(1);

            //Size size = sizeService.GetSizeById(1);

            //Console.WriteLine(size.Name);
        }
    }
}