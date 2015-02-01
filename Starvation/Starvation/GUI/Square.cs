using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Starvation.GUI
{
    class Square
    {
        private Texture2D pixel;

        private Rectangle rect = new Rectangle(0, 0, 100, 100);
        private int width;
        private Color col;

        public Square(Starve g, Rectangle rectangle, int thickness, Color color)
        {
            rect = rectangle;
            width = thickness;
            col = color;

            pixel = new Texture2D(g.GraphicsDevice, 1, 1, false, SurfaceFormat.Color);
            pixel.SetData(new[] { Color.White });
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //Top
            spriteBatch.Draw(pixel, new Rectangle(rect.X, rect.Y, rect.Width, width), col);
            //Left
            spriteBatch.Draw(pixel, new Rectangle(rect.X, rect.Y, width, rect.Width), col);
            //Right
            spriteBatch.Draw(pixel, new Rectangle((rect.X + rect.Width - width), rect.Y, width, rect.Height), col);
            //Bottom
            spriteBatch.Draw(pixel, new Rectangle(rect.X, rect.Y + rect.Height - width, rect.Width, width), col);
        }
    }
}
