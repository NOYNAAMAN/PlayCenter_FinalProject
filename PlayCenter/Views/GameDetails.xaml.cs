using PlayCenter.Models;
using PlayCenter.ViewModels;
using System.Windows;
using System.Windows.Media;

namespace PlayCenter.Views
{
    public partial class GameDetails : Window
    {
        public GameDetails()
        {
            InitializeComponent();
        }

        private void MoreInfoButton_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = (GameDetailsViewModel)this.DataContext; // מקבלים את ה-ViewModel
            var moreInfoWindow = new MoreInfoWindow(viewModel.SelectedGame.MoreInfo); // מעבירים את המידע הנוסף
            moreInfoWindow.ShowDialog(); // פותחים את החלון
        }



    }
}
