using Parcial1.Pages;

namespace Parcial1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AddNewContactPage), typeof(AddNewContactPage));
            Routing.RegisterRoute(nameof(ContactDetailPage), typeof(ContactDetailPage));
        }
    }
}
