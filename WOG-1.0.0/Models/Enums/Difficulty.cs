using System.Runtime.Serialization;

namespace WOG_1._0._0.Models.Enums
{
    public enum Difficulty
    {
        //0
        [EnumMember(Value = "BEGINNER")]
        BEGINNER,

        //1
        [EnumMember(Value = "INTERMEDIATE")]
        INTERMEDIATE,

        //2
        [EnumMember(Value = "ADVANCED")]
        ADVANCED,
    }
}
