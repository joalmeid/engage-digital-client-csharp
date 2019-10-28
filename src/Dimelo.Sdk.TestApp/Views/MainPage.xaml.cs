using Dimelo.Sdk.TestApp.Helpers;
using Dimelo.Sdk.TestApp.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Dimelo.Sdk.TestApp.Views
{
    /// <summary>
    /// Main page for managing list of users, threads and create a message
    /// History is kept in local json file in the Local data folder
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel = new MainViewModel();

        public MainPage()
        {
            ViewModel.MainPage = this;

            this.InitializeComponent();
        }

        private async void AddUser_Click(object sender, RoutedEventArgs e)
        {
            UserDialog dialog = new UserDialog();
            dialog.ViewModel.CurrentUser = new Models.User(ViewModel.Settings.NextUserId);
            if (await dialog.ShowAsync() == ContentDialogResult.Primary)
            {
                if (await ViewModel.SendNewUser(dialog.ViewModel.CurrentUser))
                {
                    ViewModel.Settings.Users.Add(dialog.ViewModel.CurrentUser);
                    ViewModel.Settings.NextUserId++;
                    await ViewModel.SaveSettings();
                }
            }
        }

        private async void EditUser_Click(object sender, RoutedEventArgs e)
        {
            UserDialog dialog = new UserDialog();
            dialog.ViewModel.CurrentUser = new Models.User(0);
            dialog.ViewModel.CurrentUser.Update(ViewModel.CurrentUser);
            if (await dialog.ShowAsync() == ContentDialogResult.Primary)
            {
                ViewModel.CurrentUser.Update(dialog.ViewModel.CurrentUser, false);
                await ViewModel.SaveSettings();
                await ViewModel.SendUpdateUser(ViewModel.CurrentUser);
            }
        }

        private async void DeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (await MessageHelper.ShowYesNoDialog($"Are you sure you want to delete {ViewModel.CurrentUser.ScreenName}?"))
            {
                ViewModel.Settings.Users.Remove(ViewModel.CurrentUser);
                await ViewModel.SaveSettings();
                await ViewModel.SendDeleteUser(ViewModel.CurrentUser);
            }
        }

        private async void AddThread_Click(object sender, RoutedEventArgs e)
        {
            ThreadDialog dialog = new ThreadDialog();
            dialog.ViewModel.CurrentThread = new Models.Thread(ViewModel.Settings.NextThreadId);
            dialog.ViewModel.UpdateCategoriesWithCurrentThread();
            dialog.ViewModel.Users = ViewModel.Settings.Users;
            if (await dialog.ShowAsync() == ContentDialogResult.Primary)
            {
                if (await ViewModel.SendNewThread(dialog.ViewModel.CurrentThread))
                {
                    ViewModel.Settings.NextThreadId++;
                    ViewModel.Settings.Threads.Add(dialog.ViewModel.CurrentThread);
                    await ViewModel.SaveSettings();
                }
            }
        }

        private async void EditThread_Click(object sender, RoutedEventArgs e)
        {
            ThreadDialog dialog = new ThreadDialog();
            dialog.ViewModel.CurrentThread = new Models.Thread(0);
            dialog.ViewModel.CurrentThread.Update(ViewModel.CurrentThread, false);
            dialog.ViewModel.UpdateCategoriesWithCurrentThread();
            dialog.ViewModel.Users = ViewModel.Settings.Users;
            if (await dialog.ShowAsync() == ContentDialogResult.Primary)
            {
                ViewModel.CurrentThread.Update(dialog.ViewModel.CurrentThread);
                await ViewModel.SaveSettings();
                await ViewModel.SendUpdateThread(ViewModel.CurrentThread);
            }
        }

        private async void DeleteThread_Click(object sender, RoutedEventArgs e)
        {
            if (await MessageHelper.ShowYesNoDialog($"Are you sure you want to delete {ViewModel.CurrentThread.Title}?"))
            {
                ViewModel.Settings.Threads.Remove(ViewModel.CurrentThread);
                await ViewModel.SaveSettings();
                await ViewModel.SendDeleteThread(ViewModel.CurrentThread);
            }
        }

        private void ResetMessage_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.ResetMessage();
        }

        private async void SendMessage_Click(object sender, RoutedEventArgs e)
        {
            if (await ViewModel.SendNewMessage(ViewModel.NewMessage))
            {
                ViewModel.Settings.Messages.Add(ViewModel.NewMessage);
                ViewModel.Settings.NextMessageId++;
                await ViewModel.SaveSettings();
            }
        }

        /// <summary>
        /// Log in the LogWindow field on the screen
        /// </summary>
        /// <param name="text">Text to add to the LogWindow. Can include newlines</param>
        /// <param name="clearFirst">Indicates if we need to clear the LogWindow first</param>
        public async void Log(string text, bool clearFirst = false)
        {
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.High, () =>
            {
                if (clearFirst) LogWindow.Text = "";
                LogWindow.Text += text + "\n";
            });
        }
    }
}
