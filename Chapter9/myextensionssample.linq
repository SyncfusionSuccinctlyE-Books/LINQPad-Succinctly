<Query Kind="Statements">
  <Reference Relative="..\customassembly\bin\Debug\customassembly.dll">C:\LINQPad_Succinctly\customassembly\bin\Debug\customassembly.dll</Reference>
</Query>

var properName = "THIS IS A PROPER NAME"; 
properName.Proper().Dump();
DateTime.Now.BackNDays(3).Dump();
DateTime.Now.ForwardNDays(5).Dump();
DateTime.Now.ToXmlSchemaDateTime().Dump();
