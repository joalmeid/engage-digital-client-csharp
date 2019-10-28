using Dimelo.Sdk.TestApp.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Dimelo.Sdk.TestApp.Views
{
    public sealed partial class ThreadDialog : ContentDialog
    {
        public ThreadViewModel ViewModel = new ThreadViewModel();
        public MainViewModel Main;

        public ThreadDialog()
        {
            this.InitializeComponent();
        }

        private void OK_Click(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            ViewModel.UpdateCurrentThreadWithCategories();
        }

        private void Cancel_Click(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {

        }

        private void AddCategory_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditCategory_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteCategory_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
