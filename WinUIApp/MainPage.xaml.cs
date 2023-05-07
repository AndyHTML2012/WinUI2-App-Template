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

// For blank page item templates, Please refer to: https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411

namespace App1
{
    /// <summary>
    /// A blank page that can be used by itself or moved into a frame.
    /// </summary>

    public sealed partial class MainPage : BasicPage
    {
        public MainPage()
        {
            InitializeComponent();
            MicaTitle(AppTitleBar, AppTitle);
        }

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {

        }

        // EXAMPLE CONTENT DIALOG
        private async void ShowDialog_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog dialog = new ContentDialog();
            dialog.Title = "TEST WINUI2 APP";
            dialog.Content = "Version 1.0";
            //dialog.PrimaryButtonText = "Save";
            //dialog.SecondaryButtonText = "Don't Save";
            dialog.CloseButtonText = "OK";
            dialog.DefaultButton = ContentDialogButton.Primary;
            //dialog.Content = new ContentDialogContent();

            var result = await dialog.ShowAsync();
        }
    }
}
