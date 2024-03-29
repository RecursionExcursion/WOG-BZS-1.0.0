﻿using WOG_1._0._0.Models;
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
                EnumPackager.GetPackagedEnums<Equipment>(),
                EnumPackager.GetPackagedEnums<Difficulty>()
            ];
        }

        public ServiceResponse<Workout> CreateWorkout(WorkoutOrder order)
        {
            if (!OrderValidator.IsOrderValid(order, out string errorResponse))
            {
                return ServiceResponse<Workout>.GenerateResponse(errorMsg: errorResponse);
            };

            Workout workout = WorkoutGenerator.GenerateWorkout(order, GetExercises(), out errorResponse);

            if (workout.Exercises.Count > 0)
            {
                return ServiceResponse<Workout>.GenerateResponse(data: workout);
            }
            else
            {
                return ServiceResponse<Workout>.GenerateResponse(errorMsg: errorResponse);
            }
        }
    }
}
