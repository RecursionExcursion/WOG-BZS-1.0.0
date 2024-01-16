using Microsoft.AspNetCore.Mvc;
using WOG_1._0._0.Models;
using WOG_1._0._0.Service;
using WOG_1._0._0.Service.DTO;

namespace WOG_1._0._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutController(WorkoutService service) : ControllerBase
    {

        private readonly WorkoutService service = service;

        [HttpGet]
        public List<Exercise> GetExercises()
        {
            return service.GetExercises();
        }

        [HttpGet("types")]
        public List<List<EnumTypesDTO>> GetEnumTypes()
        {
            return service.GetEnumTypes();
        }

        [HttpGet("create")]
        public IActionResult Create([FromBody] WorkoutOrder order)
        {
            var response = service.CreateWorkout(order);

            if (response.Success)
            {
                return Ok(response.Data);
            }
            else
            {
                return BadRequest(response.Error);
            }
        }
    }
}
