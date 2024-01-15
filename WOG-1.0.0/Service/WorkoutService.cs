using WOG_1._0._0.Models;
using WOG_1._0._0.Models.Enums;
using WOG_1._0._0.Repository;

namespace WOG_1._0._0.Service
{
    public class WorkoutService(WorkoutRepository repository)
    {

        private WorkoutRepository repository = repository;

        public string GetString()
        {
            return "Hello from service";
        }


        public Exercise GetExerciseTest()
        {
            return new Exercise()
            {
                Name = "Push Up",
                Equipment = Equipment.BODY_WEIGHT,
                MuscleGroups = new List<MuscleGroup>()
                {
                    MuscleGroup.CHEST,
                    MuscleGroup.TRICEPS
                }
            };
        }
        public Workout GetWorkoutTest()
        {
            return new Workout();
        }

        public List<MuscleGroup> GetMuscleGroups()
        {
            return null;
        }

        public List<MuscleGroup> GetEquipment()
        {
            return null;
        }

    }
}
