using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WOG_1._0._0.Service;

namespace WOG_1._0._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutController : ControllerBase
    {

        private WorkoutService service;

        public WorkoutController(WorkoutService service)
        {
            this.service = service;
        }


        [HttpGet]
        public string Get()
        {
            return service.GetString();
        }
    }
}
