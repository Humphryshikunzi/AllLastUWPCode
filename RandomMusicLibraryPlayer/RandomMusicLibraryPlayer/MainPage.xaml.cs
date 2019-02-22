using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.FileProperties;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using RandomMusicLibraryPlayer.Assets;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RandomMusicLibraryPlayer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            songs=new ObservableCollection();
        }

        private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            StorageFolder folder = KnownFolders.MusicLibrary;
            var allsongs = new ObservableCollection<StorageFile>();
            await GetMusicFromAllfolders(allsongs, folder);
            var randomsongs = await PickRandomSongs(allsongs);

        }

        public async Task GetMusicFromAllfolders(ObservableCollection<StorageFile> list, StorageFolder parent)
        {
            foreach (var VARIABLE in await parent.GetFilesAsync())
            {
                if(VARIABLE.FileType==".mp3") list.Add(VARIABLE);
            }

            foreach (var VARIABLE in await parent.GetFoldersAsync())
            {
                GetMusicFromAllfolders(list,VARIABLE);
            }
        }

        private async Task< List<StorageFile>> PickRandomSongs(ObservableCollection<StorageFile> allsongs)
        {
            Random random=new Random();
            var randomsongs = new List<StorageFile>();
            var songnumber = allsongs.Count;
            while (randomsongs.Count<4)
            {
                var randomnumber = random.Next(songnumber);
                var randomsong = allsongs[randomnumber];
                bool isdublicate=false;

                MusicProperties randomsongMusicProperties = await randomsong.Properties.GetMusicPropertiesAsync();
                foreach (var song in randomsongs)
                {
                    MusicProperties songMusicProperties = await song.Properties.GetMusicPropertiesAsync();
                    if (string.IsNullOrWhiteSpace(songMusicProperties.Album) ||
                        randomsongMusicProperties.Album == songMusicProperties.Album)
                        isdublicate = true;
                }
                if(!isdublicate)
                randomsongs.Add(randomsong);
              
            }
            return randomsongs;
        }

        private async void Populatesonglist(List<StorageFile> files)
        {
            foreach (var  file in files)
            {
                MusicProperties songProperties = await file.Properties.GetMusicPropertiesAsync();
                StorageItemThumbnail currentthumbnail = await file.GetThumbnailAsync(ThumbnailMode.MusicView, 200
                    , ThumbnailOptions.UseCurrentScale);
                var song = new Models();
                song.Name = songProperties.Artist;
                song.Length = (double)songProperties.Duration.Minutes;
                song.Itemtype = songProperties.Album;
                song.

            }
        }
    }
}
