<Query Kind="Statements" />

string filename = Util.CurrentQueryPath.Replace(".linq",".html");
string greeting = "Hello World";
File.WriteAllText(filename,Util.ToHtmlString(greeting));
