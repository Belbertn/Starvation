using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Starvation
{
    class Tile
    {
        private Texture2D texture;
        private Vector2 position;
        public void Load(ContentManager content, string assetName, Vector2 position)
        {
            texture = content.Load<Texture2D>(assetName);

            this.position = position;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
