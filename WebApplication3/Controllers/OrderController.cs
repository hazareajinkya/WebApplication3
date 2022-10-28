using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Repositories;

namespace WebApplication3.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderRepository OrderRepository;
        public OrderController()
        {
            OrderRepository = new OrderRepository();
        }

        [HttpPost]
        [Route("PlaceOrder")]
        public IActionResult PlaceOrder(Order Order)
        {
            try
            {
                OrderRepository.PlaceOrder(Order);
                return StatusCode(200, "Order Placed");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpGet]
        [Route("ViewAllOrderDetails")]
        public IActionResult ViewAllOrderDetails(Order Order)
        {
            try
            {
                return StatusCode(200, OrderRepository.ViewAllOrderDetails(Order));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        //
        [HttpGet]
        [Route("ViewOrderDetails/{OrderId}")]
        public IActionResult ViewOrderDetails(int OrderId)
        {
            try
            {
                return StatusCode(200, OrderRepository.ViewOrderDetails(OrderId));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
