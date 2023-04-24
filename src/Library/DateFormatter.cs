namespace TestDateFormat
{
    public static class DateFormatter
    {
        public static string ChangeFormat(string date)
        {
            return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
        }

        public static string ChangeFormat(DateTime date, string format)
        {
            switch (format)
            {
                case "US":
                    return date.ToString("MM/dd/yyyy");
                case "UK":
                    return date.ToString("dd/MM/yyyy");
                default:
                    return "";
            }
        }
    }
}

