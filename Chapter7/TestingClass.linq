<Query Kind="Program" />

void Main()
{
     var dateTimeManager = new DateTimeManager();
	 dateTimeManager.toXmlSchemaDateTime(DateTime.Now).Dump("toXmlSchemaDateTime method");
     dateTimeManager.backNDays(DateTime.Now,3).Dump("backNDays method");
	 dateTimeManager.forwardNDays(DateTime.Now,15).Dump("forwardNDays method");
}

// Define other methods and classes here
public class DateTimeManager
{
      public string toXmlSchemaDateTime(DateTime currentDateTime)
       {
    var xmlschemaDatetime = XmlConvert.ToString(DateTime.Now,XmlDateTimeSerializationMode.Unspecified);
           xmlschemaDatetime = xmlschemaDatetime.Substring(0,xmlschemaDatetime.IndexOf("."));
	     
	      return (xmlschemaDatetime);
       }
	   
	   public DateTime backNDays(DateTime currentDateTime, int daysToGoBack)
	   {
	          return (currentDateTime.Subtract(TimeSpan.FromDays(daysToGoBack)));
	   }
	   
	   public DateTime forwardNDays(DateTime currentDateTime, int daysToGoBack)
	   {
	          return (currentDateTime.Add(TimeSpan.FromDays(daysToGoBack)));
	   }
}
