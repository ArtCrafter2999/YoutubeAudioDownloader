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
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Command;

namespace YoutubeAudioDownloader
{
    /// <summary>
    /// Логика взаимодействия для NewVideoWindow.xaml
    /// </summary>
    public partial class NewVideoWindow : Window, INotifyPropertyChanged
    {
        public VideoModel CurrentVideo { get; set; }
        public NewVideoWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
        public ICommand OKCommand => new RelayCommand(o =>
        {
            DialogResult = true;
            Close();
        }, o=> CurrentVideo!=null);
        private void Window_Activated(object sender, EventArgs e)
        {
            string CBText = Clipboard.GetText();
            if (VideoModel.VideoRegex.IsMatch(CBText))
            {
                CurrentVideo = new VideoModel(CBText);
                OnPropertyChanged("CurrentVideo");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
