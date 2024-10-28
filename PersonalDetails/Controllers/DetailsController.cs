using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using PersonalDetails.Classes;
using PersonalDetails.Models;

namespace PersonalDetails.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DetailsController : Controller
    {
        [HttpGet("{dOB}/{fullName}")]
        public ActionResult<ResponseObject> Details(DateTime dOB, string fullName)
        {
            var response = ProcessDetails.GetResponse(dOB, fullName).Result;
            return Ok(response);
        }
    }
}
