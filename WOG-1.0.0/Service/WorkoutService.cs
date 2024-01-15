using WOG_1._0._0.Models;
using WOG_1._0._0.Models.Enums;
using WOG_1._0._0.Repository;
using WOG_1._0._0.Service.DTO;

namespace WOG_1._0._0.Service
{
    public class WorkoutService(WorkoutRepository repository)
    {

        private WorkoutRepository repository = repository;

        public string GetString()
        {
            return "Hello from service";
        }

        public Workout GetWorkoutTest()
        {
            return new Workout();
        }

        public List<Exercise> GetExercises()
        {
            return repository.GetExercises();
        }

        public List<EnumTypesDTO> GetEquipment()
        {
            return EquipmentHelper.GetEquipment();
        }


        public List<EnumTypesDTO> GetMuscleGroups()
        {
            return MuscleGroupHelper.GetMuscleGroups();
        }

    }
}
