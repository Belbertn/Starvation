using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Starvation
{
    class Tile
    {
        private Asset asset { get; set; }
        private Vector2 position;
        public void Load(Starve g, string assetName, Vector2 position)
        {
            this.position = position;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
