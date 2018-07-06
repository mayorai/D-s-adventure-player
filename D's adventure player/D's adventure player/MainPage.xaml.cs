using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace D_s_adventure_player
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>


    public sealed partial class MainPage : Page
    {
        public MediaPlayer player = new MediaPlayer();

        public Windows.Storage.StorageFile playfile;

        public MainPage()
        {
            this.InitializeComponent();
            //player.Source = MediaSource.CreateFromUri(new Uri(@"ms-appdata:///debug.wav"));
        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            player.Source = MediaSource.CreateFromStorageFile(playfile);
            player.Play();
        }

        private async void open_Click(object sender, RoutedEventArgs e)
        {
            var filePicker = new Windows.Storage.Pickers.FileOpenPicker();
            filePicker.FileTypeFilter.Add(".wav");
            filePicker.FileTypeFilter.Add(".flac");
            playfile = await filePicker.PickSingleFileAsync();
        }
    }
}
