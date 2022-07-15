using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Command;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace YoutubeAudioDownloader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public void SaveMP3(string SaveToFolder, VideoModel video)
        {
            var Video = new VideoModel(video.Url);
            var source = @SaveToFolder + "\\";
            File.WriteAllBytes(source + Video.Video.FullName+".mp3", Video.Video.GetBytes());
            ProgressValue++;
        }
        public static Regex InvalidSym = new Regex("[\\\\\\/\\:\\*\\?\\\"\\<\\>\\|]");
        public static ObservableCollection<VideoModel> Videos = new ObservableCollection<VideoModel>();
        public string Folder = @"C:\Users\Admin\Desktop\New music";
        private double _progressValue;
        public double ProgressValue { get => _progressValue; set { _progressValue = value; OnPropertyChanged("ProgressValue"); } }
        public ICommand AddCommand => new RelayCommand(o =>
        {
            var newWindow = new NewVideoWindow();
            if (newWindow.ShowDialog() == true)
            {
                Videos.Add(newWindow.CurrentVideo);
            }
        });
        public ICommand SaveCommand => new RelayCommand(o =>
        {
            if (ProgressValue > 0)
            {
                MessageBox.Show("Внимание! Установка предыдущих видео ещё не завершена",
                    "Установка ещё не завершена", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                var dialog = new CommonOpenFileDialog();
                dialog.IsFolderPicker = true;
                Progress.Maximum = Videos.Count + 1;
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    Folder = dialog.FileName;
                    var VideosTemp = new List<VideoModel>(Videos);
                    Task.Run(() =>
                    {
                        var VideosCopy = new List<VideoModel>(VideosTemp);
                        ProgressValue = 1;
                        foreach (var Video in VideosCopy)
                        {
                            SaveMP3(Folder, Video);
                        }
                        ProgressValue = 0;
                    });
                    Videos.Clear();
                }
            }
        });
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Videos.CollectionChanged += new NotifyCollectionChangedEventHandler(Videos_Changed);
        }

        public void Videos_Changed(object sender, NotifyCollectionChangedEventArgs e)
        {
            Wrap.Children.Clear();
            foreach (var Video in Videos)
            {
                Wrap.Children.Add(Video.GetViewModel());
                Scroll.ScrollToEnd();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
