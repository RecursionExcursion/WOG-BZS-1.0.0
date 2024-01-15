using System.Runtime.Serialization;
using WOG_1._0._0.Service.DTO;

namespace WOG_1._0._0.Models.Enums
{
    public enum Equipment
    {
        [EnumMember(Value = "BODY_WEIGHT")]
        BODY_WEIGHT,

        [EnumMember(Value = "BARBELL")]
        BARBELL,

        [EnumMember(Value = "KETTLEBELL")]
        KETTLEBELL,


        [EnumMember(Value = "STRAIGHT_BAR")]
        STRAIGHT_BAR
    }
}
