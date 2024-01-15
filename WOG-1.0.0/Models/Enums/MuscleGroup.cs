using System.Runtime.Serialization;
using WOG_1._0._0.Service.DTO;

namespace WOG_1._0._0.Models.Enums
{
    public enum MuscleGroup
    {
        [EnumMember(Value = "CHEST")]
        CHEST,

        [EnumMember(Value = "BACK")] 
        BACK,

        [EnumMember(Value = "LEGS")] 
        LEGS,

        [EnumMember(Value = "CORE")] 
        CORE,

        [EnumMember(Value = "TRICEPS")]
        TRICEPS,

        [EnumMember(Value = "BICEPS")] 
        BICEPS
    }
}
