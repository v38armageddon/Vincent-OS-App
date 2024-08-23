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

namespace Vincent.OS.App.Pages;

public sealed partial class DesktopPage : Page
{
    private DispatcherTimer timer;

    public DesktopPage()
    {
        this.InitializeComponent();
        InitializeTimer();
    }

    private void InitializeTimer()
    {
        timer = new DispatcherTimer();
        timer.Interval = TimeSpan.FromSeconds(1); // Update every second
        timer.Tick += Timer_Tick;
        timer.Start();
    }

    private void Timer_Tick(object sender, object e)
    {
        DateTime date = DateTime.Now;
        string day = date.ToString("dd/MM/yyyy");
        string time = date.ToString("HH:mm:ss");
        dateTimeText.Text = $"{day} {time}"; // Update the text to include the date
    }

    // Top bar
    private async void logoutButton_Click(object sender, RoutedEventArgs e)
    {
        Dialogs.LogoutDialog logoutDialog = new Dialogs.LogoutDialog();
        logoutDialog.XamlRoot = this.XamlRoot;
        ContentDialogResult result = await logoutDialog.ShowAsync();
    }
}
