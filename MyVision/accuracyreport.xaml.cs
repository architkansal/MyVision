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

namespace MyVision
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class accuracyreport : Page
    {
        public static int data;
        public accuracyreport()
        {
            InitializeComponent();
           
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var ob = e.Parameter as object;
            textBox.Text = "Your Score is : ";
            textBox.Text += ob.ToString();
            textBox.Text += "!";
            String str = ob.ToString();
            if((str).Equals("100"))
            {
                textBox.Text += "\n  Hurray!! You have perfect eye-sight and superb accuracy.";
            }
            if ((str).Equals("90"))
            {
                textBox.Text += "\n Your vision is pretty good.You have close to Normal vision.";
            }
            if ((str).Equals("80"))
            {
                textBox.Text += "\n  You seem to have problem with your vision. You should consider consulting with your eye doctor and undergo proper checkup.";
            }
            if ((str).Equals("70"))
            {
                textBox.Text += "\n  You seem to have problem with your vision. You should consider consulting with your eye doctor and undergo proper checkup.";
            }
            if ((str).Equals("60"))
            {
                textBox.Text += "\n  You seem to have problem with your vision. You should consider consulting with your eye doctor and undergo proper checkup.";
            }
            if ((str).Equals("50"))
            {
                textBox.Text += "\n  You seem to have problem with your vision. You should consider consulting with your eye doctor and undergo proper checkup.";
            }
            if ((str).Equals("40"))
            {
                textBox.Text += "\n  You seem to have problem with your vision. You should consider consulting with your eye doctor and undergo proper checkup.";
            }
            if ((str).Equals("30"))
            {
                textBox.Text += "\n  You seem to have problem with your vision. You should consider consulting with your eye doctor and undergo proper checkup.";
            }
            if ((str).Equals("20"))
            {
                textBox.Text += "\n  You seem to have problem with your vision. You should consider consulting with your eye doctor and undergo proper checkup.";
            }
            if ((str).Equals("10"))
            {
                textBox.Text += "\n  You seem to have problem with your vision. You should consider consulting with your eye doctor and undergo proper checkup.";
            }
            if ((str).Equals("0"))
            {
                textBox.Text += "\n  You seem to have problem with your vision. You should consider consulting with your eye doctor and undergo proper checkup.";
            }

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(testlist),null);
        }
    }
}



