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
using Windows.UI.Xaml.Media.Imaging;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MyVision
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class colortest : Page
    {
        static int count = 0, page = 1;
        public colortest()
        {
            this.InitializeComponent();
           
            this.get_image();
        }

        private void get_image()
        {
            if (page == 16)
            {
                end();
            }
            Uri uri = new Uri(BaseUri, "Assets/"+page+".jpg");
            BitmapImage imgSource = new BitmapImage(uri);
            this.image.Source = imgSource;
           
 
            get_options();
        }

        private void get_options()
        {
            button2.Content = "GET RESULT";
            if (page == 1)
            {
                button.Content = "12";
                button1.Content = "18";
            }
            else if(page==2)//*
            {
                button.Content = "3";//normal
                button1.Content = "8";//red-green clr blinf   
            }
            else if (page == 3)
            {
                button.Content = "29";
                button1.Content = "70";//rg
            }
            else if (page == 4)//*
            {
                button.Content = "2";
                button1.Content = "5";
            }
            else if (page == 5)
            {
                button.Content = "3";
                button1.Content = "5";
            }
            else if (page == 6)
            {
                button.Content = "15";
                button1.Content = "17";
            }
            else if (page == 7)
            {
                button.Content = "74";
                button1.Content = "21";
            }
            else if (page == 8)
            {
                button.Content = "NOTHING";
                button1.Content = "6";
            }
            else if (page == 9)
            {
                button.Content = "45";
                button1.Content = "NOTHING";
            }
            else if (page == 10)
            {
                button.Content = "5";
                button1.Content = "NOTHING";
            }
            else if (page == 11)
            {
                button1.Content = "7";
                button.Content = "NOTHING";
            }
            else if (page == 12)
            {
                button1.Content = "16";
                button.Content = "NOTHING";
            }
            else if (page == 13)
            {
                button.Content = "73";
                button1.Content = "NOTHING";
            }
            else if (page == 14)
            {
                button1.Content = "NOTHING";
                button.Content = "5";
            }
            else if (page == 15)
            {
                button1.Content = "NOTHING";
                button.Content = "45";
            }







        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
             
        }

   

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (page == 1 || page == 3 || page == 5 || page == 6 || page == 7 || page == 9 || page == 10 || page == 13)
                count++;
            next_page();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (page == 2 || page == 4 || page == 8|| page == 11 || page == 12 || page == 14 || page == 15 )
                count++;
            next_page();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            end();
        }

        private void next_page()
        {
            page++;
            get_image();
            
        }
        private void end()
        {
            int perc = ((count * 100) / page);
            object obj = perc;

            Frame.Navigate(typeof(color_test_res), obj);
        }
    }
}
