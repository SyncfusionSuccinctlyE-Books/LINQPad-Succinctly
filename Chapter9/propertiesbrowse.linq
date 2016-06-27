<Query Kind="Program">
  <Connection>
    <ID>7dd2de25-f5e8-4582-9f30-0cb1472dbcdb</ID>
    <Persist>true</Persist>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>C:\LINQPad_Succinctly\uspostalcodes\bin\Debug\uspostalcodes.dll</CustomAssemblyPath>
    <CustomTypeName>uspostalcodes.uspostalcodesEntities</CustomTypeName>
    <AppConfigPath>C:\LINQPad_Succinctly\uspostalcodes\bin\Debug\uspostalcodes.dll.config</AppConfigPath>
  </Connection>
  <Reference Relative="..\customassembly\bin\Debug\customassembly.dll">C:\LINQPad_Succinctly\customassembly\bin\Debug\customassembly.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Drawing.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Windows.Forms.dll</Reference>
  <Namespace>System.Drawing</Namespace>
  <Namespace>System.Windows.Forms</Namespace>
</Query>

void Main()
{
	var custombutton = new CustomButton();
	var properties = custombutton.Properties();
	properties.Dump();
}

// Define other methods and classes here
public class CustomButton : System.Windows.Forms.Button
{
    public CustomButton()
	{
         Text = "Custom Button Class";
         Font = new System.Drawing.Font("Segoe UI",12);
	}
}