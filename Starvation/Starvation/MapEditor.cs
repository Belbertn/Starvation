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
        private Texture2D spriteSheet;
        private Asset dirt;
        private Asset grass;
        private AssetManager assetMan = new AssetManager();

        public void Load(Starve g)
        {
            assetMan.Load(g);
            spriteSheet = assetMan.SpriteSheet;
            grass = assetMan.GetAssetData("Grass");
            dirt = assetMan.GetAssetData("Dirt");
        }

        public void Update(Starve g, GameTime gameTime)
        {
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            
            
        }
    }
}
