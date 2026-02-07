using Parcial1.Models;

namespace Parcial1.Pages;

[QueryProperty(nameof(ContactModel), "Contact")]
public partial class ContactDetailPage : ContentPage
{
    private ContactModel _contactModel;

    public ContactModel ContactModel
    {
        set
        {
            _contactModel = value;
        }
    }

    public ContactDetailPage()
    {
        InitializeComponent();
        _contactModel = new ContactModel();

    }

    override protected void OnAppearing()
    {
        base.OnAppearing();
        nameLabel.Text = _contactModel.Name;
        phoneLabel.Text = _contactModel.Phone;
    }


}