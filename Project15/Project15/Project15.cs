using Jypeli;
using Jypeli.Assets;
using Jypeli.Controls;
using Jypeli.Widgets;
using System;
using System.Collections.Generic;

namespace Project15
{
    public class Project15 : Game
    {

        

        public void DrawSnowman(int balls, double x, double y, Color col)

        {
            double size = 100;
            for (int i = 1; i <= balls; i++)
            {
                GameObject ball = new GameObject(size, size);
                ball.Color = col;
                ball.X = x;
                ball.Y = y;
                ball.Shape = Shape.Circle;
                Add(ball);
                y = y + size / 2 + size /4;
                size = size / 2;
            }

        }
public void DrawSnowman(int balls, int x, int y)
        {
            DrawSnowman(balls, x, y, Color.White);

        }
        public override void Begin()
        {
            // Kirjoita ohjelmakoodisi tähän
            DrawSnowman(4, -100, -100, Color.Green);

           // Camera.ZoomToAllObjects(50);

            PhoneBackButton.Listen(ConfirmExit, "Lopeta peli");
            Keyboard.Listen(Key.Escape, ButtonState.Pressed, ConfirmExit, "Lopeta peli");
        }
    }
}