using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Windows.Media.Core;
using Windows.Storage.Pickers;
using Windows.Storage;

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
            if (My.MyProject.Forms.Bureau.Visible == true)
            {
                My.MyProject.Forms.Bureau.Button19.Visible = true;
            }
            else if (My.MyProject.Forms.Bureau2.Visible == true)
            {
                My.MyProject.Forms.Bureau2.Button19.Visible = true;
            }
        }

        // Menu
        private void ouvrirMusiqueMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void ouvrirVideoMenu_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker p = new FileOpenPicker();
            p.FileTypeFilter.Add(".mp4");
            p.FileTypeFilter.Add(".mkv");
            p.FileTypeFilter.Add(".wmv");
            p.FileTypeFilter.Add(".mov");
            p.FileTypeFilter.Add(".avi");
            StorageFile file = await p.PickSingleFileAsync();
            if (file == null) return;
            //var source = MediaSource.CreateFromStorageFile(file);
            //mediaElement.Source = source;
            //mediaElement.AutoPlay = true;
        }

        private void arreterMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void pleinEcranMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void quitterMenu_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
