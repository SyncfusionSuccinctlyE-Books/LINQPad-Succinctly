<Query Kind="Program">
  <Reference Relative="..\customassembly\bin\Debug\customassembly.dll">C:\LINQPad_Succinctly\customassembly\bin\Debug\customassembly.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Drawing.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Windows.Forms.dll</Reference>
  <Namespace>System.Drawing</Namespace>
  <Namespace>System.Windows.Forms</Namespace>
</Query>

void Main()
{
   var custombutton = new CustomButton();

#if CMD
   string filename = Util.CurrentQueryPath.Replace(".linq",".html");
   File.WriteAllText(filename,Util.ToHtmlString(custombutton));
#else
   custombutton.Dump();
#endif
}

public class CustomButton : Button
{
    public CustomButton()
	{
	     FlatStyle = FlatStyle.Flat;
		 BackColor = Color.FromArgb(244,152,31);
		 ForeColor = Color.Black;
         Font = new Font("Segoe UI",12);
         Text = "Custom Button Class Flat Version";
	}
}
