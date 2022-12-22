using ConsoleApp1.DAL;
using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    internal class PizzaService
    {
        public Pizza GetById(int id)
        {
            Pizza pizza;
            using (AppDbContext dbContext = new AppDbContext())
            {
                pizza = dbContext.Pizzas.FirstOrDefault(p => p.Id == id);
            }
            return pizza;
        }
        public Size GetSizeById(int id)
        {
            Size size;
            using (AppDbContext dbContext = new AppDbContext())
            {
                size = dbContext.Sizes.Include(p=>p.Pizza).FirstOrDefault(p => p.Id == id);
            }
            return size;
        }
        public void CreatePizza(string name, double price)
        {
            Pizza pizza = new Pizza
            {
                Name = name,
                Price = price
            };
            using(AppDbContext context = new AppDbContext())
            {
                context.Pizzas.Add(pizza);
                context.SaveChanges();
                Console.WriteLine("Successfully Added");
            }
        }
        public List<Pizza> GetAll()
        {
            List<Pizza> pizzas;
            using (AppDbContext context = new AppDbContext())
            {
                pizzas=context.Pizzas.ToList();
            }
            return pizzas;
        }
        public void Remove(int id)
        {
            Pizza existed;
            using (AppDbContext dbContext = new AppDbContext())
            {
                existed = dbContext.Pizzas.FirstOrDefault(p => p.Id == id);
                if (existed!=null)
                {
                    dbContext.Pizzas.Remove(existed);
                    dbContext.SaveChanges();
                    Console.WriteLine("Successfully Deleted");
                }
            }
        }
    }
}
