using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace game1135
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Game selectedGame;
        public event PropertyChangedEventHandler? PropertyChanged;

        public List<Game> Games {  get; set; }
        public Game SelectedGame
        {
            get=> selectedGame;
            set
            {
                selectedGame = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedGame)));
            }
        }


        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void OpenAddWindow(object sender, RoutedEventArgs e)
        {
            AddGame addGame = new AddGame();
            addGame.Show();
        }

        private void OpenAboutGameStudio(object sender, RoutedEventArgs e)
        {
            AboutGameStudio aboutGameStudio = new AboutGameStudio();
            aboutGameStudio.Show();
        }
    }
}