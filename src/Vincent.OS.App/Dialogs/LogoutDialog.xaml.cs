/*
 * Vincent OS App, This is the repository of the project of the mini operating system Open Source: Vincent OS
 * Copyright (C) 2016 - 2024 - v38armageddon
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;

namespace Vincent.OS.App.Dialogs;

public sealed partial class LogoutDialog : ContentDialog
{
    public LogoutDialog()
    {
        this.InitializeComponent();
        this.Loaded += (s, e) => questionText.Text = Windows.ApplicationModel.Resources.ResourceLoader
            .GetForCurrentView()
            .GetString("LogoutDialog_QuestionText.Text");
    }

    private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
    {
        //switch (dropDownButton.Content) // Rewriten from scratch and already made shit code here
        //{
        //    case "Shutdown Vincent OS App":
                
        //        break;
        //    case "Restart Vincent OS App":
                
        //        break;
        //    case "Logout Vincent OS App":
                
        //        break;
        //}
    }

    private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
    {
        return;
    }

    private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
    {
        // Handle the menu item selection here
        var menuItem = (MenuFlyoutItem)sender;
        string selectedOption = menuItem.Text;

        // Perform actions based on the selected option
        switch (selectedOption) // Rewriten from scratch and already made shit code here
        {
            case "Shutdown Vincent OS App":
                menuItem.Text = "Shutdown Vincent OS App";
                break;
            case "Restart Vincent OS App":
                menuItem.Text = "Restart Vincent OS App";
                break;
            case "Logout Vincent OS App":
                menuItem.Text = "Logout Vincent OS App";
                break;
        }
    }
}
