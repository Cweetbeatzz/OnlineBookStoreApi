using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using OnlineBookStoreApi.BookStoreRepository;
using OnlineBookStoreApi.Database;
using OnlineBookStoreApi.UnitOfWork;



namespace OnlineBookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        //############################################################


        private readonly IUnitOfWork uow;
        private readonly OnlineBookStoreDbcontext db;

        public BooksController(IUnitOfWork uow, OnlineBookStoreDbcontext db)
        {
        
            this.uow = uow;
            this.db = db;
        }
        
  
        //############################################################
        // DELETE api/<BooksController>/2
        [HttpDelete("{ids}")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete([FromRoute] string ids)
        {
            try
            {
                if (string.IsNullOrEmpty(ids))
                    return BadRequest("Book ids are required.");

                var idList = ids.Split(',').Select(int.Parse).ToList();

                var success = await this.uow.booksRepo.DeleteBooks(idList);

                if (!success)
                {
                    return NotFound("Books with these ids were not found.");
                }

                return NoContent(); 
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An unknown error occurred: " + ex.Message);
            }
        }


    }
}
