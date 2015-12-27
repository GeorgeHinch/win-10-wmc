using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Windows_10_WMC
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Menu : Page
    {
        systemTime timer;
        systemTime system_Time;

        public Menu()
        {
            this.InitializeComponent();

            load_Time();

        }
        
        public void load_Time()
        {
            System_Time.Text = DateTime.Now.ToString("h" + ":" + "mm" + " " + "tt");
            //System_Time.Text = system_Time.ToString();
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            MainPage.mainPage.MainFrame.Navigate(typeof(Menu));
        }

        private void TV_Click(object sender, RoutedEventArgs e)
        {
            MainPage.mainPage.MainFrame.Navigate(typeof(Guide));
        }

        private void Movies_Click(object sender, RoutedEventArgs e)
        {
            MainPage.mainPage.MainFrame.Navigate(typeof(Movies));
        }

        private void More_Hover(object sender, RoutedEventArgs e)
        {
            //MoreHoverArrow.Visibility = Visibility.Visible;
            More_Line.Stroke = new SolidColorBrush(Color.FromArgb(255, 140, 186, 63));
            More_Arrow.Fill = new SolidColorBrush(Color.FromArgb(255, 140, 186, 63));
        }

        private void More_Hover_Exit(object sender, RoutedEventArgs e)
        {
            More_Line.Stroke = new SolidColorBrush(Color.FromArgb(255, 191, 191, 191));
            More_Arrow.Fill = new SolidColorBrush(Color.FromArgb(255, 191, 191, 191));
        }
    }
}
