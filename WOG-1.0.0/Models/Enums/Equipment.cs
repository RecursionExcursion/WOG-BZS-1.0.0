using System.Runtime.Serialization;
using WOG_1._0._0.Service.DTO;

namespace WOG_1._0._0.Models.Enums
{
    public enum Equipment
    {
        //0
        [EnumMember(Value = "BODY_WEIGHT")]
        BODY_WEIGHT,

        //1
        [EnumMember(Value = "BARBELL")]
        BARBELL,

        //2
        [EnumMember(Value = "KETTLEBELL")]
        KETTLEBELL,

        //3
        [EnumMember(Value = "STRAIGHT_BAR")]
        STRAIGHT_BAR
    }
}
