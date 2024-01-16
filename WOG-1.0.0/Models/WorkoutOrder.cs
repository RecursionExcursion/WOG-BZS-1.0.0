using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using WOG_1._0._0.Models.Enums;

namespace WOG_1._0._0.Models
{
    public class WorkoutOrder
    {
        [Required]
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [Required]
        [JsonPropertyName("numberOfExercises")]
        public int? NumberOfExercises { get; set; }

        [Required]
        [JsonPropertyName("repeatExercises")]
        public bool? RepeatExercises { get; set; }

        [JsonPropertyName("equipment")]
        public List<Equipment> Equipment { get; set; } = new List<Equipment>();

        [JsonPropertyName("muscleGroups")]
        public List<MuscleGroup> MuscleGroups { get; set; } = new List<MuscleGroup>();
    }
}
