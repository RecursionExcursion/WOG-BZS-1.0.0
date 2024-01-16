using System.Text;
using WOG_1._0._0.Models;

namespace WOG_1._0._0.Service.Helpers
{
    public static class OrderValidator
    {
        private static readonly string invalidStatement = "has been referenced successfully but object format is invalid";

        public static bool IsOrderValid(WorkoutOrder order, out string errorString)
        {
            StringBuilder errorStringBuilder = new StringBuilder();

            ValidateEnumTypes(order.Equipment, errorStringBuilder);
            ValidateEnumTypes(order.MuscleGroups, errorStringBuilder);
            ValidateEnumTypes(order.Difficulties, errorStringBuilder);

            errorString = errorStringBuilder.ToString();

            if (string.IsNullOrEmpty(errorString))
            {
                return true;
            }

            errorString += "\nPlease use GET 'workout/types' to refrence accepted types";

            return false;
        }


        private static void ValidateEnumTypes<T>(List<T> enumTypes, StringBuilder errorStringBuilder) where T : Enum
        {
            if (enumTypes.Count > 0)
            {
                if (!ValidateEnums(enumTypes))
                {
                    if (errorStringBuilder.Length > 0)
                    {
                        errorStringBuilder.Append('\n');
                    }
                    errorStringBuilder.Append($"{typeof(T).Name} {invalidStatement}");
                }
            }
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
