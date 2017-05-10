using System;

namespace Katas
{
    public static class FirstLetterUppercase
    {
        public static bool IsFirstLetterUppercase(string value)
        {
            return char.IsUpper(value[0]);
        }
    }
}
