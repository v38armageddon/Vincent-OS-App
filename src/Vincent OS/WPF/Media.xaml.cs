using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace Vincent_OS.WPF
{
    public partial class Media : Window
    {
        public Media()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (bureau.Visible == true)
            {
                bureau.Button19.Visible = true;
            }
            else if (bureau2.Visible == true)
            {
                bureau2.Button19.Visible = true;
            }
        }

        // Menu
        private void ouvrirMusiqueMenu_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Musique|*.mp3;*.wav;*.midi;*.wma";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                mediaElement.Source = new Uri(filePath);
                mediaElement.Play();
                InitializePropertyValues();
            }
        }

        private void ouvrirVideoMenu_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Vidéos|*.mp4;*.mkv;*.wmv;*.avi";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                mediaElement.Source = new Uri(filePath);
                mediaElement.Play();
                InitializePropertyValues();
            }
        }

        private void arreterMenu_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Source = null;
            mediaElement.Stop();
        }

        private void quitterMenu_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Source = null;
            mediaElement.Stop();
            Close();
        }

        private void timelineSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int SliderValue = (int)timelineSlider.Value;
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, SliderValue);
            mediaElement.Position = ts;
        }

        private void volumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaElement.Volume = (double)volumeSlider.Value;
        }

        private void mediaElement_MediaOpened(object sender, RoutedEventArgs e)
        {
            timelineSlider.Maximum = mediaElement.NaturalDuration.TimeSpan.TotalMilliseconds;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if (bureau.Visible == true)
            {
                bureau.Button19.Visible = false;
            }
            else if (bureau2.Visible == true)
            {
                bureau2.Button19.Visible = false;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        void InitializePropertyValues()
        {
            mediaElement.Volume = (double)volumeSlider.Value;
        }

        private void mediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            mediaElement.Source = null;
            mediaElement.Stop();
        }

        private void playButton_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Play();
            pauseButton.Visibility = Visibility.Visible;
            playButton.Visibility = Visibility.Collapsed;
        }

        private void pauseButton_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Pause();
            pauseButton.Visibility = Visibility.Collapsed;
            playButton.Visibility = Visibility.Visible;
        }
    }
}
