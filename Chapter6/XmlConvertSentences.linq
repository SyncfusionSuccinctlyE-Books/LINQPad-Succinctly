<Query Kind="Statements" />

var xmlschemaDatetime = XmlConvert.ToString(DateTime.Now,XmlDateTimeSerializationMode.Unspecified);
xmlschemaDatetime = xmlschemaDatetime.Substring(0,xmlschemaDatetime.IndexOf("."));
xmlschemaDatetime.Dump();
