namespace Katas
{
    public static class FirstLetterUppercase
    {
        public static bool IsFirstLetterUppercase(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }
            return char.IsUpper(value[0]);
        }
    }
}
