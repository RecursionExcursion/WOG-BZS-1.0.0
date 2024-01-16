using System.Text;
using WOG_1._0._0.Models;

namespace WOG_1._0._0.Service.Helpers
{
    public static class OrderValidator
    {
        public static bool IsValidOrder(WorkoutOrder order, out string errorString)
        {
            StringBuilder errorStringBuilder = new StringBuilder();

            if (order.Equipment.Count > 0)
            {
                if (!ValidateEnums(order.Equipment))
                {
                    errorStringBuilder.Append("Equipment is invalid");
                }
            }

            if (order.MuscleGroups.Count > 0)
            {
                if (!ValidateEnums(order.MuscleGroups))
                {
                    if(errorStringBuilder.Length > 0)
                    {
                        errorStringBuilder.Append('\n');
                    }
                    errorStringBuilder.Append("MuscleGroups is invalid");
                }
            }

            errorString = errorStringBuilder.ToString();

            if (string.IsNullOrEmpty(errorString))
            {
                return true;
            }

            return false;
        }

        private static bool ValidateEnums<T>(List<T> enums) where T : Enum
        {

            List<T> castedEnums = enums.Cast<T>().ToList();

            Type enumType = typeof(T);

            foreach (var val in castedEnums)
            {
                if (!Enum.IsDefined(enumType, val))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
