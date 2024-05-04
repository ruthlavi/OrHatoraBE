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
        private readonly IavrechBll avrBll;
        public AvrechController(IavrechBll avrBll) 
        {
            this.avrBll = avrBll;
        }

        [HttpGet]
        public ActionResult <AvrechDto> getById(string id)
        {
            try { return Ok(avrBll.getStudentById(id)); }
            catch (Exception ex) { return Ok(ex.Message); }
            //return Ok(avrBll.getStudentById(id));
        }

        [HttpPost]
        public ActionResult newStudentReg(Avrech a)
        {
            return Ok(avrBll.newStudentReg(a));
        }
    }
}
