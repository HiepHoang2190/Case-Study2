using Microsoft.EntityFrameworkCore;
using Selling_Phone.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Selling_Phone.Models
{
    public class SqlProducRepository : IProductRepository
    {
        private readonly AppDbContext context;

        public SqlProducRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Product Create(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return product;
        }

        public bool Delete(int id)
        {
            var delPro = context.Products.Find(id);
            if (delPro != null)
            {
                context.Products.Remove(delPro);
                return context.SaveChanges() > 0;
            }
            return false;
        }

        public Product Edit(Product product)
        {
            var editPro = context.Products.Attach(product);
            editPro.State = EntityState.Modified;
            context.SaveChanges();
            return product;
        }

        public Product Get(int id)
        {
            return (from p in context.Products
                        where p.ProductId == id
                        select p).FirstOrDefault();
        }

        public IEnumerable<Product> Gets()
        {
            return context.Products;
        }

    
    }
}
