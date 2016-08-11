<Query Kind="Statements">
  <Connection>
    <ID>85e005ee-afee-4220-a54b-48309a19fbe9</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <SqlSecurity>true</SqlSecurity>
    <UserName>sa</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAApIpboxkMi0KXQm107ZYAoQAAAAACAAAAAAAQZgAAAAEAACAAAAA+o+wHUy4p9YtPQHc6h3Z2iDT27pglGNufB4QfBcSsjgAAAAAOgAAAAAIAACAAAACzh0XHY0HGZRWj2OtOHIb5sql57QDheDKHaViWbjvUNxAAAADAXx61ZFnJ/kwA+/G+4QhGQAAAAKSn7scekFSBo+9qFy6+vWGupy1VlDQav9CAYcj5Z47lyfLG1RdXZuM/UIN6Cgu9tDkN+nBnHtGbRH6iF37G9F4=</Password>
    <Database>uspostalcodes</Database>
    <ShowServer>true</ShowServer>
  </Connection>
  <Reference Relative="..\customassembly\bin\Debug\customassembly.dll">C:\LINQPad_Succinctly\customassembly\bin\Debug\customassembly.dll</Reference>
</Query>

var obj=new { a=Counties.Where(row => row.State_id == 21).Select(row => new {row.County_id, row.County_name}), b="Hello World", c= States.Take(States.Count()), d=new { y=5, z=10 } };
obj.Dump(description: "Excluding c and d", toDataGrid: false, exclude: "c,d");
obj.Dump("Excluding a and b", exclude: "a,b");
