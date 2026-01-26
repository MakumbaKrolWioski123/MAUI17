namespace MauiApp15;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}

	void OnImageTapped(object sender, EventArgs e)
	{
		DisplayAlert("Ile psów ma w³aœciciel firmy lays?", "Czypsy", "OK");
    }

	void OnBoxViewTapped(object sender, EventArgs e)
	{
		DisplayAlert("Jak sie nazywa przyprawa która myœli?", "Kminek", "OK");
    }
}