using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineBookStoreApi.BookStoreRepository;
using OnlineBookStoreApi.UnitOfWork;

namespace OnlineBookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RevenueController : ControllerBase
    {
   
        private readonly IUnitOfWork uow;
        //############################################################

        public RevenueController(IUnitOfWork uow)
        {
         
            this.uow = uow;
        }
        //############################################################


        [HttpGet("get-revenue")]
        public async Task<IActionResult> GetRevenue([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            if (startDate > endDate)
            {
                return BadRequest("StartDate must be less than or equal to EndDate.");
            }

            if (startDate == DateTime.MinValue || endDate == DateTime.MinValue || endDate < startDate)
            {
                return BadRequest("The date range provided is invalid.");
            }

            var revenue = await this.uow.ordersRepo.GetRevenue(startDate, endDate);

            return Ok(new { StartDate = startDate, EndDate = endDate, Revenue = revenue });
        }
        //#########################################################################################

    }
}
