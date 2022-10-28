using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        /*
        private readonly ProductDbContext productDbContext;
        public ProductController(ProductDbContext productDbContext)
        {
            this.productDbContext = productDbContext;
        }
        */

        private readonly ProductRepository ProductRepository;
        public BookController()
        {
            BookRepository = new BookRepository();
        }
        
        [HttpGet]
        [Route("GetAllProducts")]
        public IActionResult GetAllProducts(Product Product)
        {
            try
            {
                return StatusCode(200, ProductRepository.GetAllProducts(Product));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        //
        [HttpGet]
        [Route("GetProductsById/{ProductId}")]
        public IActionResult GetProductsById(int ProductId)
        {
            try
            {
                return StatusCode(200, ProductRepository.GetProductsById(ProductId));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("Delete/{ProductId}")]
        public IActionResult DeleteProduct(int ProductId)
        {
            try
            {
                BookRepository.DeleteProduct(ProductId);
                return StatusCode(200, "Record Deleted");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        //
        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProduct(Product Product)
        {
            try
            {
                BookRepository.AddProduct(Product);
                return StatusCode(200, "Record Added");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
        [HttpPut]
        [Route("UpdateProduct")]
        public IActionResult UpdateProduct(Product Product)
        {
            try
            {
                BookRepository.UpdateProduct(Product);
                return StatusCode(200, "Record Updated");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


    }
}
