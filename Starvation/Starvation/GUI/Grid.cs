using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Starvation.GUI
{
    class Grid : IUserInterface
    {
        public Rectangle area { get; set; }

        private int lines;
        private int columns;
        private int squareSizeX;
        private int squareSizeY;
        private int thick;
        private Color color;

        public Grid(Starve g, int lines, int columns, int squareSizeX, int squareSizeY, int thickness, Color color)
        {
            this.lines = lines;
            this.columns = columns;
            this.squareSizeX = squareSizeX;
            this.squareSizeY = squareSizeY;
            this.thick = thickness;
            this.color = color;

            CreateGrid(g);
        }

        public void Update(Starve g, GameTime gameTime)
        {

        }

        public void Draw(Starve g)
        {

        }

        private void CreateGrid(Starve g)
        {
            for(int x = 0; x < lines; x++)
            {
                for(int y = 0; y < columns; y++)
                {
                    
                }
            }
        }
    }
}
