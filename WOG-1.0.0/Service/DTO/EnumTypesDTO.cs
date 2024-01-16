namespace WOG_1._0._0.Service.DTO
{
    public record EnumTypesDTO(string Name, int Value);

    public class EnumPackager
    {
        public static List<EnumTypesDTO> GetPackagedEnums<TEnum>()
            where TEnum : Enum
        {
            var enumList = new List<EnumTypesDTO>();
            foreach (TEnum e in Enum.GetValues(typeof(TEnum)))
            {
                enumList.Add(new EnumTypesDTO(e.ToString(), (int)(object)e));
            }
            return enumList;
        }
    }
}
