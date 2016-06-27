<Query Kind="Program" />

void Main()
{
	// Write code to test your extensions here. Press F5 to compile and run.
}

public static class MyExtensions
{
  	public static Dictionary<string, object> Properties(this object myself)
	{
		return myself.GetType().GetProperties().Where(prop => prop.CanRead).ToDictionary(prop => prop.Name, prop => prop.GetValue(myself));
     }
	 
        public static string Proper(this string inputString)
        {
            if (inputString == string.Empty) return string.Empty;

            if (inputString.Contains(" "))
            {
                var result = string.Empty;
                var wordsList = inputString.Split(' ');
                result = wordsList.Aggregate(result, (current, word) => current + (word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " "));
                return result.Trim();
            }

            return inputString.Substring(0, 1).ToUpper() + inputString.Substring(1).ToLower();
        }
	// Write custom extension methods here. They will be available to all queries.

	public static DateTime BackNDays(this DateTime currentDateTime, int daysToGoBack)
        {
            return (currentDateTime.Subtract(TimeSpan.FromDays(daysToGoBack)));
        }

     public static DateTime ForwardNDays(this DateTime currentDateTime, int daysToGoBack)
        {
            return (currentDateTime.Add(TimeSpan.FromDays(daysToGoBack)));
        }

        public static string ToXmlSchemaDateTime(this DateTime currentDateTime)
        {
            var xmlschemaDatetime = XmlConvert.ToString(DateTime.Now, XmlDateTimeSerializationMode.Unspecified);
            xmlschemaDatetime = xmlschemaDatetime.Substring(0, xmlschemaDatetime.IndexOf(".", StringComparison.Ordinal));

            return (xmlschemaDatetime);
        }

}

// You can also define non-static classes, enums, etc.