using System.Runtime.Serialization;
using WOG_1._0._0.Service.DTO;

namespace WOG_1._0._0.Models.Enums
{
    public enum MuscleGroup
    {
        //0
        [EnumMember(Value = "CHEST")]
        CHEST,

        //1
        [EnumMember(Value = "BACK")] 
        BACK,

        //2
        [EnumMember(Value = "LEGS")] 
        LEGS,

        //3
        [EnumMember(Value = "CORE")] 
        CORE,

        //4
        [EnumMember(Value = "TRICEPS")]
        TRICEPS,

        //5
        [EnumMember(Value = "BICEPS")] 
        BICEPS
    }
}
