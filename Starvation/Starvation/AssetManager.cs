using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Starvation
{
    class AssetManager
    {
        private Texture2D spriteSheet;

        public void Load(Starve g)
        {
            spriteSheet = g.Content.Load<Texture2D>("spritesheet");

            
        }
    }
}
