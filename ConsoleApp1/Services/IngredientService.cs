using ConsoleApp1.DAL;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    internal class IngredientService
    {
        public Ingredient GetById(int id)
        {
            Ingredient ingredient;
            using (AppDbContext dbContext = new AppDbContext())
            {
                ingredient = dbContext.Ingredients.FirstOrDefault(i => i.Id == id);
            }
            return ingredient;
        }
        public void CreateIngredient(string name)
        {
            Ingredient ingredient = new Ingredient
            {
                Name = name
            };
            using (AppDbContext context = new AppDbContext())
            {
                context.Ingredients.Add(ingredient);
                context.SaveChanges();
                Console.WriteLine("Successfully Added");
            }
        }
        public List<Ingredient> GetAll()
        {
            List<Ingredient> ingredients;
            using (AppDbContext context = new AppDbContext())
            {
                ingredients = context.Ingredients.ToList();
            }
            return ingredients;
        }
        public void Remove(int id)
        {
            Ingredient existed;
            using (AppDbContext dbContext = new AppDbContext())
            {
                existed = dbContext.Ingredients.FirstOrDefault(i => i.Id == id);
                if (existed != null)
                {
                    dbContext.Ingredients.Remove(existed);
                    dbContext.SaveChanges();
                    Console.WriteLine("Successfully Deleted");
                }
            }
        }
    }
}
