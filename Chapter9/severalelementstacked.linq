<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\WPF\PresentationCore.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\WPF\PresentationFramework.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Drawing.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Windows.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Windows.Forms.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Xaml.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\WPF\WindowsBase.dll</Reference>
  <Namespace>System.Drawing</Namespace>
  <Namespace>System.Windows.Controls</Namespace>
  <Namespace>System.Windows.Forms</Namespace>
</Query>

List<System.Windows.UIElement> elements = new List<System.Windows.UIElement> {new System.Windows.Controls.Button {Content = "My Button"},  new System.Windows.Controls.Label {Content = "My Label"}, new System.Windows.Controls.Expander {Header = "More"}};
elements.StackWpfControls();
