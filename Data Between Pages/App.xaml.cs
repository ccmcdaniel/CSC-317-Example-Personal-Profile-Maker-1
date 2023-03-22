namespace Data_Between_Pages;

public partial class App : Application
{
	public static string name = "";
	public static DateTime birthday = DateTime.Now;
	public static string picsource = "";
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
