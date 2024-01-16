using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using WOG_1._0._0.Models.Enums;

namespace WOG_1._0._0.Models
{
    public class WorkoutOrder
    {
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; } = String.Empty;

        [Required]
        [JsonPropertyName("numberOfExercises")]
        public int NumberOfExercises { get; set; } = 0;

        [Required]
        [JsonPropertyName("repeatExercises")]
        public bool RepeatExercises { get; set; } = true;

        [JsonPropertyName("equipment")]
        public List<Equipment> Equipment { get; set; } = [];

        [JsonPropertyName("muscleGroups")]
        public List<MuscleGroup> MuscleGroups { get; set; } = []; 
        
        [JsonPropertyName("difficulty")]
        public List<Difficulty> Difficulties { get; set; } = [];
    }
}
