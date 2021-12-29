using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Command;
namespace YoutubeAudioDownloader
{
    /// <summary>
    /// Логика взаимодействия для VideoViewModel.xaml
    /// </summary>
    public partial class VideoViewModel : UserControl
    {
        public VideoModel Video {get; set;}
        public ICommand RemoveCommand => new RelayCommand(o => { MainWindow.Videos.Remove(Video);});
        public VideoViewModel(VideoModel video)
        {
            InitializeComponent();
            DataContext = this;
            Video = video;
        }
    }
}
