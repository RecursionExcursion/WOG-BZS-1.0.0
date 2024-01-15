using WOG_1._0._0.Models.Enums;

namespace WOG_1._0._0.Models
{
    public class Exercise
    {
        public string Name { get; set; } = null!;

        public Equipment Equipment { get; set; }

        public List<MuscleGroup> MuscleGroups { get; set; } = new List<Enums.MuscleGroup>();

        public string? Notes { get; set; }
    }
}
