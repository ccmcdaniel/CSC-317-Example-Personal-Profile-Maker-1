namespace Data_Between_Pages;

public partial class Personal_Page : ContentPage
{
	public Personal_Page()
	{
		InitializeComponent();
		lblName.Text = App.name;
		lblBirthday.Text = App.birthday.ToLongDateString();

		int age = DateTime.Now.Year - App.birthday.Year;

		if (DateTime.Now.Month - App.birthday.Month < 0 || 
			DateTime.Now.Day - App.birthday.Day < 0)
			age -= 1;

		lblAge.Text = $"{age} years old as of today.";

		imgPicture.Source = App.picsource;
	}
}