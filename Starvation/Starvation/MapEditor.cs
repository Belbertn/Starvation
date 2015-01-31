using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Starvation
{
    class MapEditor : IGameState
    {
        AssetManager assetMan = new AssetManager();
        public void Load(Starve g)
        {
            assetMan.Load(g);
        }

        public void Update(Starve g, GameTime gameTime)
        {
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
