using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Vincent_OS_App.Views;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;


namespace Vincent_OS_App.Dialogs
{
    public sealed partial class PowerDialog : ContentDialog
    {
        public PowerDialog()
        {
            this.InitializeComponent();
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            switch (powerBox.SelectedIndex)
            {
                case 0:
                    // TODO: Vincent OS App Shutdown
                    break;
                case 1:
                    // TODO: Vincent OS App Restart
                    break;
                case 2:
                    if (Frame.CurrentSourcePageType == typeof(LoginPage))
                    {
                        // TODO: Error Dialog
                        var errorDialog = new ErrorDialog();
                        errorDialog.ShowAsync();
                    }
                    else
                    {
                        Frame.Navigate(typeof(LoginPage), null, new DrillInNavigationTransitionInfo());
                    }
                    break;
                case 3:
                    Process.Start("shutdown", "/s /t 0");
                    break;
                case 4:
                    Process.Start("shutdown", "/r /t 0");
                    break;
            }
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            return;
        }
    }
}
