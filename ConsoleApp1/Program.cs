using SFML;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

class Program
{
    static void Main()
    {
        VideoMode mode = new VideoMode(600, 500);

        RenderWindow window = new RenderWindow(mode, "Test");
        window.SetVerticalSyncEnabled(true);
        Shape shape = new CircleShape(40);
        shape.FillColor = Color.Yellow;
        window.Closed += (sender, args) => window.Close();

        int a = 0;
        Text text = new Text(a.ToString(), font: new Font("assets/Roboto-Regular.ttf"));
    
        while (window.IsOpen)
        {
            text.Color = Color.White;
            text.Position = new Vector2f(window.Size.X / 2, window.Size.Y / 2);
            text.DisplayedString = a.ToString();
            a++;
            window.DispatchEvents();
            window.Draw(text);
            window.Draw(shape);
            window.Display();
            window.Clear();
        }
    }
}