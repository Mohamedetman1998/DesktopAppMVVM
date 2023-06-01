using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Page_Navigation_App.View
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : MetroAnimatedTabControl
    {
        public Game()
        {
            InitializeComponent();
        }

      

        private void TetrisClicked(object sender, RoutedEventArgs e)
        {
            var Tetris=new Tetris();
            Tetris.Show();
        }

        private void SnakeClicked(object sender, RoutedEventArgs e)
        {
            var Snake = new Snake();
            Snake.Show();
        }

        private void XOClicked(object sender, RoutedEventArgs e)
        {
            var xo = new XO();
            xo.Show();
        }
    }
}
