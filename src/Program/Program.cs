using System;

namespace TestDateFormat
{
    public static class Program
    {
        public static void Main()
        {
            string testDate = "10/11/1997";
            Console.WriteLine($"{testDate} se convierte a {DateFormatter.ChangeFormat(testDate)}");

            var date = new DateTime(2023, 4, 24);
            Console.WriteLine($"{date} se convierte a {DateFormatter.ChangeFormat(date, "US")}");
            Console.WriteLine($"{date} se convierte a {DateFormatter.ChangeFormat(date, "UK")}");
            Console.WriteLine($"{date} se convierte a {DateFormatter.ChangeFormat(date, "invalid")}");
        }
    }
}
