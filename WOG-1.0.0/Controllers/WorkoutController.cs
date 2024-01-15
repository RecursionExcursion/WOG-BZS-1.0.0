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


        [HttpGet("equipment")]
        public List<EnumTypesDTO> GetEquipment()
        {
            var foo =  service.GetEquipment();
            return foo;
        }

        [HttpGet("musclegroups")]
        public List<EnumTypesDTO> GetMuscleGroups()
        {
            return service.GetMuscleGroups();
        }

    }
}
