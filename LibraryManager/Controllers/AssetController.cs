using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryService;
using LibraryService.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
//added
namespace LibraryManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetController : ControllerBase
    {
        private readonly ILibraryService _service;
        public AssetController(ILibraryService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("createBook")]
        public IActionResult CreateBranch(CreateBookRequest request)
        {
            var response = _service.CreateBook(request);
            return Ok(response);
        }

        [HttpPost]
        [Route("createVideo")]
        public IActionResult CreateVideo(CreateVideoRequest request)
        {
            var response = _service.CreateVideo(request);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetAllUsersList")]
        public IActionResult GetAllUsersList()
        {
            var response = _service.GetAllUsersList();
            return Ok(response);
        }
    }
}
