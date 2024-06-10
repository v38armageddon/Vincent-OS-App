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
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Vincent.OS.App
{
    public partial class App : Application
    {
        MainWindow mainWindow = new MainWindow();

        private void AppStart(object sender, StartupEventArgs e)
        {
            // Set the window to fullscreen
            mainWindow.WindowState = WindowState.Maximized;
            mainWindow.WindowStyle = WindowStyle.None;

            // Place here to start the default page
            Pages.Startup startup = new Pages.Startup();
            mainWindow.mainFrame.NavigationService.Navigate(startup);

            // Init the window
            mainWindow.InitializeComponent();
            mainWindow.Show();
        }
    }
}
