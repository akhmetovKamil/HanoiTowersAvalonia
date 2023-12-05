using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.Imaging;

namespace HanoiTowers;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        var board = new BoardClass(5);
        Main.Children.Add(board.Board);
        
    }
    
    
}