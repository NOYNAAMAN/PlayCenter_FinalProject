using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PlayCenter.Views
{
    /// <summary>
    /// Interaction logic for MoreInfoWindow.xaml
    /// </summary>
    public partial class MoreInfoWindow : Window
    {
        public MoreInfoWindow(string moreInfo)
        {
            InitializeComponent();

            MoreInfoText.Text = moreInfo;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                button.Background = new SolidColorBrush(Color.FromRgb(0, 120, 180)); // צבע כהה יותר
            }
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                button.Background = new SolidColorBrush(Color.FromRgb(0, 120, 212)); // צבע רגיל
            }
        }

    }
}