using System.ComponentModel.DataAnnotations;
using WOG_1._0._0.Models.Enums;

namespace WOG_1._0._0.Models
{
    public class Workout
    {
        [Required] 
        public string Name { get; set; } = null!;


        [EnumDataType(typeof(Equipment))]
        public List<Equipment> Equipment { get; set; } = new List<Equipment>();


        [EnumDataType(typeof(MuscleGroup))]
        public List<MuscleGroup> MuscleGroups { get; set; } = new List<MuscleGroup>();


        public List<Exercise> Exercises { get; set; } = new List<Exercise>();


        [Required]
        public int NumberOfExercises { get; set; } = 0;


        [Required]
        public bool RepeatExercies { get; set;  } = false;


        public string? Description { get; set; }
    }
}
