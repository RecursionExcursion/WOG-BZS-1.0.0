using WOG_1._0._0.Models.Enums;

namespace WOG_1._0._0.Models
{
    public class Workout
    {
        public string Name { get; set; } = null!;

        public List<Equipment> Equipment { get; set; } = new List<Equipment>();

        public List<MuscleGroup> MuscleGroups { get; set; } = new List<MuscleGroup>();

        public int NumberOfExercises { get; set; } = 0;

        public bool RepeatExercies { get; set;  } = false;

        public string? Description { get; set; }
    }
}
