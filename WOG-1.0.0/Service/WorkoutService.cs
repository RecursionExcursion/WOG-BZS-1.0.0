using WOG_1._0._0.Models;
using WOG_1._0._0.Models.Enums;
using WOG_1._0._0.Repository;
using WOG_1._0._0.Service.DTO;
using WOG_1._0._0.Service.Helpers;

namespace WOG_1._0._0.Service
{
    public class WorkoutService(WorkoutRepository repository)
    {

        private readonly WorkoutRepository repository = repository;

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

        internal List<List<EnumTypesDTO>> GetEnumTypes()
        {
            return
            [
                EnumPackager.GetPackagedEnums<MuscleGroup>(),
                EnumPackager.GetPackagedEnums<Equipment>()
            ];
        }

        internal string CreateWorkoutFromOrder(WorkoutOrder order)
        {
            //check if enums are valid
            if (
            EnumValidator.ValidateEnums(order.Equipment) ||
            EnumValidator.ValidateEnums(order.MuscleGroups)
                )
            {

            }





            return "foo";
        }
    }
}
