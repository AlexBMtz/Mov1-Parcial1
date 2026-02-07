namespace Parcial1.Pages;

public partial class AddNewContactPage : ContentPage
{
	public AddNewContactPage()
	{
		InitializeComponent();
	}

    private async void OnCancelClicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..");
    }
}