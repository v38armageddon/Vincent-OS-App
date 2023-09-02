using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace Vincent_OS_App.Views
{
    public sealed partial class StartPage : Page
    {
        DispatcherTimer timer = new DispatcherTimer();

        public StartPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            timer.Interval = TimeSpan.FromSeconds(3);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, object e)
        {
            while (progressBar.Value != 100)
            {
                progressBar.Value += 10;
                System.Threading.Thread.Sleep(1000);
            }
            if (progressBar.Value == 100)
            {
                timer.Stop();
                Frame.Navigate(typeof(LoginPage), null, new DrillInNavigationTransitionInfo());
                var startingSound = new MediaElement();
                startingSound.Source = new Uri("ms-appx:///Assets/Sounds/startingSound.wav");
                startingSound.Play();
            }
        }
    }
}
