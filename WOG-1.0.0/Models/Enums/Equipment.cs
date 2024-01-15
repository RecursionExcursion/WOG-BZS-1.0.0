using System.Runtime.Serialization;

namespace WOG_1._0._0.Models.Enums
{
    public enum Equipment
    {
        [EnumMember(Value = "BARBELL")]
        BARBELL,

        [EnumMember(Value = "KETTLEBELL")]
        KETTLEBELL,

        [EnumMember(Value = "BODY_WEIGHT")]
        BODY_WEIGHT,

        [EnumMember(Value = "STRAIGHT_BAR")]
        STRAIGHT_BAR
    }
}
