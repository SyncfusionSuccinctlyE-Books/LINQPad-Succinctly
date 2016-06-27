<Query Kind="Program" />

void Main()
{
     var convertedDateTime = toXmlSchemaDateTime(DateTime.Now);
	 convertedDateTime.Dump();
}

// Define other methods and classes here
public string toXmlSchemaDateTime(DateTime currentDateTime)
{
    var xmlschemaDatetime = XmlConvert.ToString(DateTime.Now,XmlDateTimeSerializationMode.Unspecified);
    xmlschemaDatetime = xmlschemaDatetime.Substring(0,xmlschemaDatetime.IndexOf("."));
	
	return (xmlschemaDatetime);
}
