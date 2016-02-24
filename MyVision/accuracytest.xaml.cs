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
    public sealed partial class accuracytest : Page
    {
        public static int count=0;
        public accuracytest()
        {
            this.InitializeComponent();
            this.get_test();
           

    }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

      

        }

        public void get_test()
        {
            
            Random num = new Random();
           
            if (count==0)
            {
                textBox1.Text = " ";
                textBox1.FontSize = 150;
                for (int i = 0; i < count * 2+2; i++)
                {
                    int var = num.Next(10, 99);
                    textBox1.Text += var.ToString()+"  ";
                }

            }
            if(count==1)
            {
                textBox1.Text = "";
                textBox1.FontSize = 130;
                for(int i=0;i<count*2+2;i++)
                {
                    int var = num.Next(10, 99);
                    textBox1.Text += var.ToString()+"  ";
                }
            }
            if (count == 2)
            {
                textBox1.Text = "";
                textBox1.FontSize = 110;
                for (int i = 0; i < count * 2; i++)
                {
                    int var = num.Next(10, 99);
                    textBox1.Text += var.ToString() + "  ";
                }
            }
            if (count == 3)
            {
                textBox1.Text = "";
                textBox1.FontSize = 90;
                for (int i = 0; i < count * 2+2; i++)
                {
                    int var = num.Next(10, 99);
                    textBox1.Text += var.ToString() + "  ";
                }
            }
            if (count == 4)
            {
                textBox1.Text = "\n";
                textBox1.FontSize = 70;
                for (int i = 0; i < count * 2; i++)
                {
                    int var = num.Next(10, 99);
                    textBox1.Text += var.ToString() + "  ";
                }
            }
            if (count == 5)
            {
                textBox1.Text = "\n";
                textBox1.FontSize = 50;
                for (int i = 0; i < count * 2-2; i++)
                {
                    int var = num.Next(10, 99);
                    textBox1.Text += var.ToString() + "  ";
                }
            }
            if (count == 6)
            {
                textBox1.Text = "\n\n";
                textBox1.FontSize = 30;
                for (int i = 0; i < count * 2-4; i++)
                {
                    int var = num.Next(10, 99);
                    textBox1.Text += var.ToString() + "  ";
                }
            }
            if (count == 7)
            {
                textBox1.Text = "\n\n";
                textBox1.FontSize = 20;
                for (int i = 0; i < count * 2-6; i++)
                {
                    int var = num.Next(10, 99);
                    textBox1.Text += var.ToString() + "  ";
                }
            }
            if (count == 8)
            {
                textBox1.Text = "\n\n\n\n";
                textBox1.FontSize = 10;
                for (int i = 0; i < count * 2 - 6; i++)
                {
                    int var = num.Next(10, 99);
                    textBox1.Text += var.ToString() + "  ";
                }
            }
            if (count == 9)
            {
                textBox1.Text = "\n\n\n\n\n\n";
                textBox1.FontSize = 8;
                for (int i = 0; i < count * 2 - 6; i++)
                {
                    int var = num.Next(10, 99);
                    textBox1.Text += var.ToString() + "  ";
                }
            }
          


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            count = 0;
            Frame.Navigate(typeof(testlist), null);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            count++;
            get_test();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            generate_result();
        }

        public void generate_result()
        {
            int pts = count * 10;
            Frame.Navigate(typeof(accuracyreport), pts);
        }
    }
}
