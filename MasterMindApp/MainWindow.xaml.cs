using System.Collections.Generic;
using System.Windows;

namespace MasterMindApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Tile[] Tiles = new Tile[40];
            icMainBoard.ItemsSource = Tiles;
        }
    }

    public class Tile
    {
        public Tile()
        {
            Color = PegColor.Empty;
        }
        public PegColor Color;
    }

    public enum PegColor
    {
        Empty,
        White,
        Blue,
        Green,
        Red,
        Yellow
    }
}
