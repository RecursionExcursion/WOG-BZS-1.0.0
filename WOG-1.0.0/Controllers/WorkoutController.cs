using Microsoft.AspNetCore.Mvc;
using WOG_1._0._0.Models;
using WOG_1._0._0.Service;

namespace WOG_1._0._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutController(WorkoutService service) : ControllerBase
    {

        private readonly WorkoutService service = service;

        [HttpGet]
        public Exercise GetExercises()
        {
            return service.GetExerciseTest();
        }
    }
}
