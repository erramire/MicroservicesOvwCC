using System;

namespace PoS.CC.Utilities
{
    public class Guard
    {
        public static void ForLessEqualZero(int value, string parameterName)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(parameterName, $"{parameterName} no puede ser igual a cero");
        }

        public static void ForLessEqualZero(decimal value, string parameterName)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(parameterName, $"{parameterName} no puede ser igual a cero");
        }

        public static void ForLessEqualZero(long value, string parameterName)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(parameterName, $"{parameterName} no puede ser igual a cero");
        }

        public static void MustBeEqualToZero(int value, string parameterName)
        {
            if (value != 0)
                throw new ArgumentOutOfRangeException(parameterName, $"{parameterName} debe tener asignado el valor de cero");
        }

        public static string DeafultToValue(string value, string defaultValue)
        {
            if (string.IsNullOrEmpty(value))
                return defaultValue;

            return value;
        }

        public static void ForNullOrEmpty(string value, string parameterName)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentOutOfRangeException(parameterName, $"{parameterName} no puede ser nulo o vacio");
        }

        public static void ForValidGuid(Guid value, string parameterName)
        {
            if (value == Guid.Empty)
                throw new ArgumentOutOfRangeException(parameterName, $"{parameterName} no puede ser nulo o vacio");
        }

        public static void ForNullObject(object target, string parameterName)
        {
            if (target == null)
                throw new ArgumentNullException(parameterName, $"{parameterName} no puede ser nulo o vacio");
        }
    }
}
