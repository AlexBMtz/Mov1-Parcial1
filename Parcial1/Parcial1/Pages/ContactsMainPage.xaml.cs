using Parcial1.Models;

namespace Parcial1.Pages;

public partial class ContactsMainPage : ContentPage
{
    private List<ContactModel> _contacts = [

        new() { Name = "John Doe", Phone = "123-456-7890" },
        new() { Name = "Jane Smith", Phone = "987-654-3210" },
        new() { Name = "Alice Johnson", Phone = "555-123-4567" }
    ];

    private List<ContactModel> _filteredContacts;

    public ContactsMainPage()
    {
        InitializeComponent();
        _filteredContacts = [.. _contacts];
        contactList.ItemsSource = _filteredContacts;
    }

    private async void OnAddContactClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AddNewContactPage));
    }

    private async void OnContactSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is ContactModel selectedContact)
        {
            await Shell.Current.GoToAsync(nameof(ContactDetailPage), new Dictionary<string, object>
            {
                { "Contact", selectedContact }
            });

            contactList.SelectedItem = null;
        }
    }
}