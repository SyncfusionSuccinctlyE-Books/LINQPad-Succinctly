<Query Kind="Statements">
  <Reference Relative="..\customassembly\bin\Debug\customassembly.dll">C:\LINQPad_Succinctly\customassembly\bin\Debug\customassembly.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Net.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Web.dll</Reference>
  <Namespace>System.Net</Namespace>
</Query>

var image = Util.Image(new WebClient().DownloadData("https://www.linux.com/sites/all/themes/custom/lcom/logo.png"));
image.Dump();
