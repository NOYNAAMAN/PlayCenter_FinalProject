

using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using PlayCenter.Models;
using PlayCenter.Views;
using PlayCenter.ViewModels;
using System.Windows.Controls.Primitives;
using System.Windows.Controls;



namespace PlayCenter
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Game> Games { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Games = new ObservableCollection<Game>
            {
                new Game { Name = "Tetris", ImagePath = "/Images/tetrist.png", Description = "Tetris is a classic puzzle game where players arrange falling blocks to clear full " +
                "rows and score points, avoiding reaching the top of the screen.", ExecutablePath = "Tetris.exe" , 
                    MoreInfo = "Developed in C# using WPF, " +
                    "the project includes responsive design with components like Canvas, Grid, and StackPanel. " +
                    "The logic is structured into separate classes," +
                    " with each game element handled independently for better organization"
                , LaunchButtonColor = "#8f39d1",
                 MoreInfoButtonColor = "#8f39d1" },

                new Game { Name = "Calendar", ImagePath = "/Images/calendar.png", Description = "The calendar app allows users to manage tasks by assigning them to specific dates, ensuring easy organization" +
                " and effective time management", ExecutablePath = "Calender.exe", 
                MoreInfo="The project is developed in C# using a DataService to manage and store user tasks. The design incorporates components like" +
                " Grid, Canvas, ViewBox, StackPanel, and more for a seamless user experience.",
                    LaunchButtonColor = "#d03c4b", MoreInfoButtonColor = "#d03c4b" },

                new Game { Name = "TicTac", ImagePath = "/Images/ticTac.png", Description = "Tic-Tac-Toe is a two-player game where players take turns marking" +
                " X and O on a 3x3 grid, aiming to align three marks in a row for the win.", ExecutablePath = "TicTacGame.exe",
                MoreInfo="The project is written in C#, using the GameState class It manages a 3x3 grid, tracks the current player, and counts turns. The code validates moves, checks win conditions," +
                " and handles events for moves, game endings, and resets. This structure ensures modularity and easy maintenance.",
                  LaunchButtonColor = "#ffc0cb", MoreInfoButtonColor = "#ffc0cb"},

                new Game { Name = "Snake", ImagePath = "/Images/snake.png", Description = "Snake is a game where the player controls a growing snake, eating food to increase in length." +
                " The game ends if the snake hits the edges or itself.", ExecutablePath = "Snake.exe" ,
                MoreInfo="The Snake game in C# uses WPF for the UI and a `GameState` class to handle logic like movement, direction, and collisions." +
                " The snake's position is stored using a linked list, and the grid updates as the game progresses. The `MainWindow.xaml.cs` handles key inputs for controlling the snake," +
                " displaying the game grid," +
                " score, and managing game loops, with countdowns and game-over screens for user interaction.",
                  LaunchButtonColor = "#80ff80", MoreInfoButtonColor = "#80ff80"},

                new Game { Name = "Pacman", ImagePath = "/Images/pacman.png", Description = "Pac-Man is an action maze game where players control Pac-Man to eat dots while avoiding four pursuing ghosts"
                , ExecutablePath = "PacManGame.exe",
                MoreInfo="The Pac-Man-style game is built using WPF, featuring a game canvas where Pac-Man navigates based on user input. The core logic includes collision detection for collecting pellets and avoiding ghosts," +
                " with a scoring system that updates as pellets are eaten. Movement and game mechanics are handled in the code-behind, while the UI is defined in XAML." +
                " The game is designed to be responsive, ensuring smooth gameplay across different screen sizes.",
                  LaunchButtonColor = "#812508", MoreInfoButtonColor = "#812508"},

                new Game { Name = "Weather", ImagePath = "/Images/rain_cloud.png", Description = "The weather app offers real-time updates and a 4-day forecast with essential weather information.", ExecutablePath = "WeatherApp.exe",
                MoreInfo="The weather project uses the OpenWeatherMap API to fetch real-time weather data, secured with an environment variable named `OWAPI_Key` containing the API's App ID." +
                " The design employs a Grid and StackPanel for a responsive layout, allowing users to input a location and receive current weather updates," +
                " including temperature, humidity, and conditions, in a clear and organized interface.",
                  LaunchButtonColor = "#6894ce", MoreInfoButtonColor = "#6894ce"},

            };

            DataContext = this;
        }

        public ICommand GameSelectedCommand => new RelayCommand<Game>(GameSelected);

        private void GameSelected(Game selectedGame)
        {
            var gameDetailsWindow = new GameDetails
            {
                DataContext = new GameDetailsViewModel(selectedGame)
            };
            gameDetailsWindow.ShowDialog();
        }



    }
}
