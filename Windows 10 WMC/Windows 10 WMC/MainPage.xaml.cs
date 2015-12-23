using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Windows_10_WMC
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static MainPage mainPage;

        public MainPage()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(Menu));
            MainPage.mainPage = this;

            Window.Current.CoreWindow.KeyDown += CoreWindow_KeyDown;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler<object>(dispatchTimer_Tick);
            timer.Start();
        }

        void CoreWindow_KeyDown(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs args)
        {
            if (args.VirtualKey == VirtualKey.L)
            {
                Debug.WriteLine("L key is pressed.");
            }

            if (args.VirtualKey == VirtualKey.G)
            {
                Debug.WriteLine("G key is pressed.");
            }

            if (args.VirtualKey == VirtualKey.Menu)
            {
                Debug.WriteLine("Menu key is pressed.");
            }

            if (args.VirtualKey == VirtualKey.M)
            {
                Debug.WriteLine("M key is pressed.");
            }
        }

        public string systemTime;

        public void dispatchTimer_Tick(object sender, object e)
        {
            systemTime = DateTime.Now.ToString("h" + ":" + "mm" + " " + "tt");
        }

        public Frame getMainFrame()
        {
            return this.MainFrame;
        }
    }
}
