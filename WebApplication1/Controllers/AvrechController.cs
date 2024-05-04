using CollelBll.DTO.modelsDto;
using CollelDal.interfaces;
using CollelDal.models;
using Microsoft.AspNetCore.Mvc;

namespace CollelPll.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvrechController : Controller
    {
        IavrechBll? avrBll;
        public AvrechController(IavrechBll avrBll) 
        {
            avrBll = this.avrBll;
        }
        public ActionResult <AvrechDto> getById(string id)
        {
            return Ok(avrBll.getStudentById(id));
        }
    }
}
