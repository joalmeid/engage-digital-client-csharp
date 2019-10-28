using Dimelo.Sdk.TestApp.ViewModels;
using Windows.UI.Xaml.Controls;

namespace Dimelo.Sdk.TestApp.Views
{
    public sealed partial class UserDialog : ContentDialog
    {
        public UserViewModel ViewModel = new UserViewModel();

        public UserDialog()
        {
            this.InitializeComponent();
        }

        private void OK_Click(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {

        }

        private void Cancel_Click(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {

        }
    }
}
