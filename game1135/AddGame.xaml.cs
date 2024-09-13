using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace game1135
{
    /// <summary>
    /// Логика взаимодействия для AddGame.xaml
    /// </summary>
    public partial class AddGame : Window, INotifyPropertyChanged
    {
        private Game selectedGame;
        public event PropertyChangedEventHandler? PropertyChanged;

        public List<Game> Games { get; set; }
        public Game SelectedGame
        {
            get => selectedGame;
            set
            {
                selectedGame = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedGame)));
            }
        }

        private GameStudio selectedGameStudio;

        public List<GameStudio> GameStudios { get; set; }
        public GameStudio SelectedGameStudio
        {
            get => selectedGameStudio;
            set
            {
                selectedGameStudio = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedGameStudio)));
            }
        }

        public AddGame()
        {
            InitializeComponent();
            selectedGame = new Game();
            DataContext = this;
            GameStudios = MysqlTools.SimpleSelectFromTable<GameStudio>();
        }

        private void AddNewGame(object sender, RoutedEventArgs e)
        {
            GameCollection.Games.Add(SelectedGame);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedGame)));
            MysqlTools.Insert(SelectedGame);
            MessageBox.Show("Game added successfully");
        }

        private void BackToMain(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
