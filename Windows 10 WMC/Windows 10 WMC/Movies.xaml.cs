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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Windows_10_WMC
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Movies : Page
    {
        public Movies()
        {
            this.InitializeComponent();

            load_Time();
            load_MainFrame();
        }

        public void load_Time()
        {
            System_Time.Text = DateTime.Now.ToString("h" + ":" + "mm" + " " + "tt");
        }

        public void load_MainFrame()
        {
            MoviesContentFrame.Navigate(typeof(Movies_Main));
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            MainPage.mainPage.MainFrame.Navigate(typeof(Menu));
        }
    }
}
