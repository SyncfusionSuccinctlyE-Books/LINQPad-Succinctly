<Query Kind="Program">
  <Reference Relative="..\customassembly\bin\Debug\customassembly.dll">C:\LINQPad_Succinctly\customassembly\bin\Debug\customassembly.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Drawing.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Windows.Forms.dll</Reference>
</Query>

void Main()
{
	var custombutton = new CustomButton();
	custombutton.Dump();
}

// Define other methods and classes here
public class CustomButton : System.Windows.Forms.Button
{
    public CustomButton()
	{
	     FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		 BackColor = System.Drawing.Color.FromArgb(244,152,31);
		 ForeColor = System.Drawing.Color.Black;
         Font = new System.Drawing.Font("Segoe UI",12);
         Text = "Custom Button Class Flat Version";
	}
}
