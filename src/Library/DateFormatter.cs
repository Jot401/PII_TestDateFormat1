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
    if (format == "US")
    {
        return date.ToString("MM/dd/yyyy");
    }
    else if (format == "UK")
    {
        return date.ToString("dd/MM/yyyy");
    }
    else
    {
        return "";
    }
}

    }
}

