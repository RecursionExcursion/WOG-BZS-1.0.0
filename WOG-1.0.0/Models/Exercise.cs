using System.Text.Json.Serialization;
using WOG_1._0._0.Models.Enums;

namespace WOG_1._0._0.Models
{
    public class Exercise
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;

        [JsonPropertyName("equipment")]
        public Equipment Equipment { get; set; }

        [JsonPropertyName("muscleGroups")]
        public List<MuscleGroup> MuscleGroups { get; set; } = new List<MuscleGroup>();

        [JsonPropertyName("notes")]
        public string? Notes { get; set; }
    }
}
