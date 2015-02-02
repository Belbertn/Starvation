using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Starvation.GUI 
{
    class Square : IUserInterface
    {
        private Texture2D pixel;

        public Rectangle area { get; set; }
        private int width;
        private Color col;

        public Square(Starve g, Rectangle Rectangle, int thickness, Color color)
        {
            area = new Rectangle(Rectangle.X * 32, Rectangle.Y * 32, Rectangle.Width, Rectangle.Height);
            width = thickness;
            col = color;

            pixel = new Texture2D(g.GraphicsDevice, 1, 1, false, SurfaceFormat.Color);
            pixel.SetData(new[] { Color.White });
        }

        public void Update(Starve g , GameTime gameTime)
        {
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //Top
            spriteBatch.Draw(pixel, new Rectangle(area.X, area.Y, area.Width, width), col);
            //Left
            spriteBatch.Draw(pixel, new Rectangle(area.X, area.Y, width, area.Width), col);
            //Right
            spriteBatch.Draw(pixel, new Rectangle((area.X + area.Width - width), area.Y, width, area.Height), col);
            //Bottom
            spriteBatch.Draw(pixel, new Rectangle(area.X, area.Y + area.Height - width, area.Width, width), col);
        }
    }
}
