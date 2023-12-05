using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media;
using Avalonia.Media.Imaging;

namespace HanoiTowers;

public class BoardClass
{
    public readonly Canvas Board;
    private Button[] _rings;

    public BoardClass(int ringsCount)
    {
        Board = new Canvas();
        
        var bitmap = new Bitmap("./assets/background.png");
        var img = new ImageBrush(bitmap)
        {
            Stretch = Stretch.Fill
        };
        Board.Background = img;
        
        var ring = new RingClass();
        
        _rings = new Button[ringsCount];
        for (int i = 0; i < ringsCount; i++)
        {
            _rings[i] = ring.CreateRing(100 - i * 10,i%2==0);
            Board.Children.Add(_rings[i]);
        }
    }
}