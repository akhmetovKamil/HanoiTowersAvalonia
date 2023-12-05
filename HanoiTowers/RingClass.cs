using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace HanoiTowers;

public class RingClass
{
    
    public Button CreateRing(int width, bool isOnTop = true)
    {
        var ring = new Button
        {
            Width = width,
            Height = 30,
            Background = Brushes.GreenYellow,
            Tag = isOnTop
        };
        ring.Click += RectOnClick;
        return ring; 
        // rect.VerticalAlignment = Avalonia.Layout.VerticalAlignment.Bottom;
    }
    

    private void RectOnClick(object? sender, RoutedEventArgs e)
    {
        var ring = (Button)sender!;
        if (ring.Tag is bool isOnTop && isOnTop)
        {
            ring.Background = Brushes.Blue;
        }
        
    }
}