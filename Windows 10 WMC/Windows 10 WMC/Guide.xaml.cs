﻿using System;
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
    public sealed partial class Guide : Page
    {
        public Guide()
        {
            this.InitializeComponent();
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            MainPage.mainPage.MainFrame.Navigate(typeof(Menu));
        }

        private void Row1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainPage.mainPage.VideoElement.Source = new Uri("ms-appx:/Assets/DonaldTrumpInterviewwithAndersonCooperonAC360.mp4", UriKind.RelativeOrAbsolute);
        }

        private void Row2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainPage.mainPage.VideoElement.Source = new Uri("ms-appx:/Assets/PropertyBrothersJonathansWorstDate.mp4", UriKind.RelativeOrAbsolute);
        }
    }
}
