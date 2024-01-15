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

    public static class EquipmentHelper
    {
        public static List<EnumTypesDTO> GetEquipment()
        {
            var equipment = new List<EnumTypesDTO>();

            foreach (Equipment e in Enum.GetValues(typeof(Equipment)))
            {
                equipment.Add(new EnumTypesDTO(e.ToString(), (int)e));
            }

            return equipment;
        }
    }
}
