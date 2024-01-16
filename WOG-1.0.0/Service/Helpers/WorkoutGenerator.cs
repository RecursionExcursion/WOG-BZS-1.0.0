using Microsoft.AspNetCore.Http.HttpResults;
using WOG_1._0._0.Models;

namespace WOG_1._0._0.Service.Helpers
{
    public static class WorkoutGenerator
    {
        public static Workout GenerateWorkout(WorkoutOrder order, List<Exercise> exercises,  out string errorResponse)
        {
            List<Exercise> filteredExercises = FilterExercises(order, exercises);

            List<Exercise> exerciseList = CreateExerciseList(order, filteredExercises, out errorResponse);

            return new Workout()
            {
                Name = order.Name,
                Exercises = exerciseList,
                RepeatExercies = order.RepeatExercises,
                Equipment = order.Equipment,
                MuscleGroups = order.MuscleGroups,
                Difficulties = order.Difficulties
            };

        }
        private static List<Exercise> FilterExercises(WorkoutOrder order, List<Exercise> exercises)
        {
            var filteredExercises = exercises;
            if (order.MuscleGroups.Count > 0)
            {
                filteredExercises = filteredExercises.Where(ex => order.MuscleGroups.Any(mg => ex.MuscleGroups.Contains(mg))).ToList();
            }
            if (order.Equipment.Count > 0)
            {
                filteredExercises = filteredExercises.Where(ex => order.Equipment.Contains(ex.Equipment)).ToList();
            }
            if (order.Difficulties.Count > 0)
            {
                filteredExercises = filteredExercises.Where(ex => order.Difficulties.Contains(ex.Difficulty)).ToList();
            }
            return filteredExercises;
        }


        private static List<Exercise> CreateExerciseList(WorkoutOrder order, List<Exercise> filteredExercises, out string errorResponse)
        {
            errorResponse = string.Empty;
            
            var rand = new Random();
            bool repeat = order.RepeatExercises;
            var exerciseList = new List<Exercise>();

            if (filteredExercises.Count < order.NumberOfExercises && !repeat)
            {
                errorResponse = "Not enough exercises with specified parameters to complete order"+
                    "\nConsider changing 'repeat' to true or loosening the parameters";
                return [];
            }

            while (exerciseList.Count < order.NumberOfExercises)
            {
                int index = rand.Next(0, filteredExercises.Count);

                exerciseList.Add(filteredExercises[index]);

                if (!repeat)
                {
                    filteredExercises.RemoveAt(index);
                }
            }
            return exerciseList;
        }
    }
}
