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

public sealed partial class StartupPage : Page
{
    public StartupPage()
    {
        this.InitializeComponent();
        //Window.Current.Title = "Vincent OS App - Starting Up...";
    }

    private void Page_Loaded(object sender, RoutedEventArgs e)
    {
        DispatcherTimer timer = new DispatcherTimer();
        timer.Interval = TimeSpan.FromSeconds(3);
        timer.Start();
        timer.Tick += (s, e) =>
        {
            timer.Stop();
            Frame.Navigate(typeof(LoginPage));
        };
    }
}
