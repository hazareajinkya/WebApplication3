
using System.Collections.Generic;
using WebApplication3.Models;
namespace WebApplication3.Repositories
{
    public class OrderRepository
    {
        private readonly ProductDbContext db;
        public ProductRepository()
        {
            this.db = new ProductDbContext();
        }
        public List<Order> ViewAllOrderDetails()
        {

            return db.Order.ToList();

        }

        public void PlaceOrder(Order order)
        {

            db.Order.Add(order);
            db.SaveChanges();

        }

        public Product ViewOrderDetails(int OrderId)
        {
            Order Order = list.SingleOrDefault(i => i.OrderId == OrderId);
            return Order;
        }


    }
}
