﻿namespace QTools
{
    public class QIntegerSchema : QSchema
    {
        const string CharType = "i";

        const string NullValue = "0Ni";

        public override string QType => "integer";

        public override string QNotation(object o) => ToQValue(o);

        public static string ToQValue(object o)
        {
            if (o != null && o is int value)
            {
                return $"{value}{CharType}";
            }

            return NullValue;
        }
    }
}
