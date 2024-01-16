using System.ComponentModel.DataAnnotations;
using WOG_1._0._0.Models.Enums;

namespace WOG_1._0._0.Models
{
    public class Workout
    {
        public string Name { get; set; } = null!;
        public int NumberOfExercises { get; set; } = 0;
        public bool RepeatExercies { get; set;  } = false;

        public List<Equipment> Equipment { get; set; } = [];
        public List<MuscleGroup> MuscleGroups { get; set; } = [];
        public List<Difficulty> Difficulties { get; set; } = [];

        public List<Exercise> Exercises { get; set; } = [];

        public string? Description { get; set; }
    }
}
