using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging.Signing;
using OnlineBookStoreApi.BookStoreRepository;
using OnlineBookStoreApi.UnitOfWork;

namespace OnlineBookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        //#########################################################################################

     
        private readonly IUnitOfWork uow;
        //#########################################################################################

        public AuthorController(IUnitOfWork uow)
        {
         
            this.uow = uow;
        }
        //#########################################################################################

        [HttpGet("top-selling")]
        public async Task<IActionResult> GetTopSellingAuthors()
        {
            var responseOfTopAuthors = await this.uow.authorRepo.GetTopSellingAuthors(10);
            return Ok(responseOfTopAuthors);
        }
        //#########################################################################################

    }
}
