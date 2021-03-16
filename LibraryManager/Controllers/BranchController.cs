using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryService;
using LibraryService.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly ILibraryService _service;
        public BranchController(ILibraryService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("create")]
        public IActionResult CreateBranch(CreateBranchRequest request)
        {
            var response = _service.CreateBranch(request);
            return Ok(response);
        }

        //[HttpGet]
        //[Route("getAll")]
        //public IActionResult GetAll( request)
        //{
        //    var response = _service.CreateBranch(request);
        //    return Ok(response);
        //}
    }
}
