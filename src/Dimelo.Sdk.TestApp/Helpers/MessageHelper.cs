using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace Dimelo.Sdk.TestApp.Helpers
{
    public static class MessageHelper
    {
        public static async Task<bool> ShowYesNoDialog(string message, string title = "Message")
        {
            MessageDialog dialog = new MessageDialog(message, title);
            dialog.Commands.Add(new UICommand("Yes", null));
            dialog.Commands.Add(new UICommand("No", null));
            dialog.DefaultCommandIndex = 0;
            dialog.CancelCommandIndex = 1;
            IUICommand cmd = await dialog.ShowAsync();

            if (cmd.Label == "Yes")
                return true;
            else
                return false;
        }
    }
}
