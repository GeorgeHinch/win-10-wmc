using System;
using System.Collections.Generic;
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
using Windows.UI.Xaml.Navigation;
using Windows.Media;
using Windows.UI;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Windows_10_WMC
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Guide : Page
    {
        public Guide()
        {
            this.InitializeComponent();

            load_Time();
        }

        public void load_Time()
        {
            System_Time.Text = DateTime.Now.ToString("h" + ":" + "mm" + " " + "tt");
        }

        public SolidColorBrush unselectedText = new SolidColorBrush(Color.FromArgb(255, 191, 191, 191));
        public SolidColorBrush selectedText = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
        public SolidColorBrush selectedRow = new SolidColorBrush(Color.FromArgb(255, 140, 186, 63));

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            MainPage.mainPage.MainFrame.Navigate(typeof(Menu));
        }

        private void Row1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainPage.mainPage.VideoElement.Source = new Uri("ms-appx:/Assets/DonaldTrumpInterviewwithAndersonCooperonAC360.mp4", UriKind.RelativeOrAbsolute);

            Row1.Background = selectedRow;
            Row1_Text.Foreground = selectedText;

            Row2.Background = null;
            Row2_Text.Foreground = unselectedText;

            ChannelStatus.Text = Channel1_Name.Text;
            ChannelNumber.Text = Channel1_Number.Text;

            Info_Image.Source = new BitmapImage(
                        new Uri("ms-appx:/Assets/anderson_cooper_360_ver6_xlg.jpg"));
            Info_Name.Text = "Anderson Cooper 360";
            Info_Synops.Text = "Anderson Cooper goes beyond the headlines to tell stories from many points of view, so you can make up your own mind about the news.";
        }

        private void Row2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainPage.mainPage.VideoElement.Source = new Uri("ms-appx:/Assets/PropertyBrothersJonathansWorstDate.mp4", UriKind.RelativeOrAbsolute);

            Row1.Background = null;
            Row1_Text.Foreground = unselectedText;

            Row2.Background = selectedRow;
            Row2_Text.Foreground = selectedText;

            ChannelStatus.Text = Channel2_Name.Text;
            ChannelNumber.Text = Channel2_Number.Text;

            Info_Image.Source = new BitmapImage(
                        new Uri("ms-appx:/Assets/087854af82aaca641c46104ac4655241-18142.jpg"));
            Info_Name.Text = "Property Brothers";
            Info_Synops.Text = "The Property Brothers are determined to help couples find, buy and transform extreme fixer-uppers into the ultimate dream home. And since it's hard to see beyond a dated property's shortcomings, they're using state-of-the-art CGI to reveal their vision of the future. Can Drew Scott and Jonathan Silver Scott convince these hesitant home buyers to take a radical risk? And can they complete their ambitious project on time and on budget?";
        }
    }
}
