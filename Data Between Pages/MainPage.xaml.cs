namespace Data_Between_Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OpenFile(object sender, EventArgs e)
	{
		
	}

	private void ShowPersonalPage(object sender, EventArgs e)
	{
		App.name = txtName.Text;
		App.birthday = datePickerBirthday.Date;
		App.picsource = txtImageFileLocation.Text;
		Navigation.PushAsync(new Personal_Page());
	}
}

