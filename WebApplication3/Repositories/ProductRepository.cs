
using System.Collections.Generic;
using WebApplication3.Models;
namespace WebApplication3.Repositories
{
    public class ProductRepository
    {
        private readonly ProductDbContext db;
        public ProductRepository()
        {
            this.db = new ProductDbContext();
        }
        public List<Product> GetAllProducts()
        {

            return db.Product.ToList();

        }

        public void AddProduct(Product product)
        {

            db.Product.Add(product);
            db.SaveChanges();

        }

        public Product GetProductById(int ProductId)
        {
            Product Product = list.SingleOrDefault(i => i.ProductId == ProductId);
            return Product;
        }

       

        public void DeleteProduct(int ProductId)
        {
            Product Product = list.SingleOrDefault(i => i.ProductId == ProductId);
            list.Remove(Product);
        }

        public void UpdateProduct(Product Product)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[0].ProductId == Product.ProductId)
                {
                    list[0].PName = Product.PName;
                    list[0].Desc = Product.Desc;
                    list[0].Price = Product.Price;
                    break;
                }
            }
        }


    }
}
