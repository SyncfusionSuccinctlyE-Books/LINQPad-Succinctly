<Query Kind="Statements" />

const string queriesPath = @"C:\LINQPad_Succinctly\Queries\";
var dummyFormat = new LINQPad.QueryResultFormat();
Util.Run(queriesPath+"getmyqueries.linq",dummyFormat).Dump();

