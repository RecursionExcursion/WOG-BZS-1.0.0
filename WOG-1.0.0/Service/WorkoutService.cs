using System.Text;
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

        public Workout GetWorkoutTest()
        {
            return new Workout();
        }

        public List<Exercise> GetExercises()
        {
            return repository.GetExercises();
        }

        public List<List<EnumTypesDTO>> GetEnumTypes()
        {
            return
            [
                EnumPackager.GetPackagedEnums<MuscleGroup>(),
                EnumPackager.GetPackagedEnums<Equipment>()
            ];
        }

        public ServiceResponse<Workout> CreateWorkout(WorkoutOrder order)
        {
            if (!OrderValidator.IsValidOrder(order, out string errorResponse))
            {
                return ServiceResponse<Workout>.GenerateResponse(
                        false, errorMsg: errorResponse);
            };

            return ServiceResponse<Workout>.GenerateResponse(
                                true, data: CreateWorkoutFromOrder(order));
        }

        private Workout CreateWorkoutFromOrder(WorkoutOrder order)
        {



            return new Workout();
        }
    }
}
