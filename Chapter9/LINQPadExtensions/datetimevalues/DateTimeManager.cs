using System;
using System.Xml;

namespace LINQPad.datetimevalues
{
    public class DateTimeManager
    {
        public string ToXmlSchemaDateTime(DateTime currentDateTime)
        {
            var xmlschemaDatetime = XmlConvert.ToString(DateTime.Now, XmlDateTimeSerializationMode.Unspecified);
            xmlschemaDatetime = xmlschemaDatetime.Substring(0, xmlschemaDatetime.IndexOf(".", StringComparison.Ordinal));

            return (xmlschemaDatetime);
        }

        public DateTime BackNDays(DateTime currentDateTime, int daysToGoBack)
        {
            return (currentDateTime.Subtract(TimeSpan.FromDays(daysToGoBack)));
        }

        public DateTime ForwardNDays(DateTime currentDateTime, int daysToGoBack)
        {
            return (currentDateTime.Add(TimeSpan.FromDays(daysToGoBack)));
        }
    }
}
