using ConsoleApp1.DAL;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    internal class SizeService
    {
        public Size GetById(int id)
        {
            Size size;
            using (AppDbContext dbContext = new AppDbContext())
            {
                size = dbContext.Sizes.FirstOrDefault(s => s.Id == id);
            }
            return size;
        }
        public void CreateSize(string name, int pizzaid)
        {
            Size size = new Size
            {
                Name = name,
                PizzaId = pizzaid
            };
            using (AppDbContext context = new AppDbContext())
            {
                context.Sizes.Add(size);
                context.SaveChanges();
                Console.WriteLine("Successfully Added");
            }
        }
        public List<Size> GetAll()
        {
            List<Size> sizes;
            using (AppDbContext context = new AppDbContext())
            {
                sizes = context.Sizes.ToList();
            }
            return sizes;
        }
        public void Remove(int id)
        {
            Size existed;
            using (AppDbContext dbContext = new AppDbContext())
            {
                existed = dbContext.Sizes.FirstOrDefault(s => s.Id == id);
                if (existed != null)
                {
                    dbContext.Sizes.Remove(existed);
                    dbContext.SaveChanges();
                    Console.WriteLine("Successfully Deleted");
                }
            }
        }
    }
}
