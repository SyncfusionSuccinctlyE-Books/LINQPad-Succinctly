<Query Kind="Statements" />

// Setting the query language to "C# Statement(s)" permits multiple statements:

var words =
	from word in "The quick brown fox jumps over the lazy dog".Split()
	orderby word.ToUpper()
	select word;
	
var duplicates =
	from word in words
	group word.ToUpper() by word.ToUpper() into g
	where g.Count() > 1
	select new { g.Key, Count = g.Count() };	
	
// The Dump extension method writes out queries:

words.Dump();
duplicates.Dump();

// Notice that we do need semicolons now!