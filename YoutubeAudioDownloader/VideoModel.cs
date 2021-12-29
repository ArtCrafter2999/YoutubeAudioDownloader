using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using VideoLibrary;

namespace YoutubeAudioDownloader
{
    public class VideoModel : INotifyPropertyChanged
    {
        public static Regex VideoRegex = new Regex(@"https:\/\/www\.youtube\.com\/watch\?v=([^&]+)");
        public VideoModel(string url)
        {
            Url = url;
            var youtube = YouTube.Default;
            Video = youtube.GetVideo(Url);
        }
        public YouTubeVideo Video { get; set; }
        public string Url { get; set; }
        public string VideoId { get => VideoRegex.Match(Url).Groups[1].Value; }
        public ImageSource Thumbnail
        {
            get
            {
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri($"https://img.youtube.com/vi/{VideoId}/0.jpg", UriKind.Absolute);
                bitmap.EndInit();
                return bitmap;
            }
        }
        public VideoViewModel GetViewModel()
        {
            return new VideoViewModel(this);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
