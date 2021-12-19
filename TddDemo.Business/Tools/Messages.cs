namespace TddDemo.Business
{
    public static  class Messages
    {
        public static string success { get; set; } = "ЕГН -то е валидно";
        public static string errorDigit { get; set; } = "ЕГН съдържа само цифрови символи!";
        public static string lengthMinMax = "Дължината на ЕГН не е 10 символа!";
        public static string invalidMonth = "Грешен месец!";
        public static string invalidDate = "Грешна дата!";
        public static string invalidLastDigit = "Неправилна последна цифра в ЕГН!";
        public static string invalidLocation = "Неправилна Дестинация!";
    }
}
