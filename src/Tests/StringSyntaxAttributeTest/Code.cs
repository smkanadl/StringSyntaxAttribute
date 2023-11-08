using System.Diagnostics.CodeAnalysis;

namespace StringSyntaxAttributeTest
{
    public static class Main
    {
        [StringSyntax(StringSyntaxAttribute.Regex)] // Remove this line to loose syntax highlight and editor support
        private const string REG_EX = "[a-z]|(:?test)*";

        public static void RegEx([StringSyntax(StringSyntaxAttribute.Regex)] string _)
        {
            _ = REG_EX;
        }

        public static void Date([StringSyntax(StringSyntaxAttribute.DateTimeFormat)] string _)
        {
        }

        public static void Use()
        {
            RegEx("[a-z]|(:?test)*");
            Date("2023-12-01");
        }
    }
}
