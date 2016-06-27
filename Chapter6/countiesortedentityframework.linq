<Query Kind="Statements">
  <Connection>
    <ID>7dd2de25-f5e8-4582-9f30-0cb1472dbcdb</ID>
    <Persist>true</Persist>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>C:\LINQPad_Succinctly\uspostalcodes\bin\Debug\uspostalcodes.dll</CustomAssemblyPath>
    <CustomTypeName>uspostalcodes.uspostalcodesEntities</CustomTypeName>
    <AppConfigPath>C:\LINQPad_Succinctly\uspostalcodes\bin\Debug\uspostalcodes.dll.config</AppConfigPath>
  </Connection>
</Query>

var countiesTable = counties.Select(row => new {row.county_id, row.county_name});
countiesTable.OrderBy(row => row.county_name);
countiesTable.Dump();

