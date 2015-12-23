using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Windows_10_WMC
{
    class systemTime
    {
        public void timer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler<object>(dispatchTimer_Tick);
            timer.Start();
        }

        public string system_Time;

        public void dispatchTimer_Tick(object sender, object e)
        {
            system_Time = DateTime.Now.ToString("h" + ":" + "mm" + " " + "tt");
            Debug.WriteLine(system_Time);
        }
    }
}
