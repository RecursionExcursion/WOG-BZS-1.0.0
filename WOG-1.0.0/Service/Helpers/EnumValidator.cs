using WOG_1._0._0.Models;

namespace WOG_1._0._0.Service.Helpers
{
    public class EnumValidator
    {
        public static bool ValidateEnums<T>(List<T> enums) where T : Enum =>
            enums.All(e => Enum.IsDefined(typeof(T), e));


        public static bool ValidateOrderEnums(WorkoutOrder order)
        {
            bool validMG = ValidateEnums(order.MuscleGroups);
            bool validEquip = ValidateEnums(order.Equipment);




            return false;

        }
    }
}
