using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Starvation.GUI
{
    abstract class UIElement 
    {
        public Vector2 Position { get; set; }

        public AssetManager assetManager { get; set; }

        private Asset asset { get; set; }

        public virtual void Load(Starve g)
        {
            assetManager = new AssetManager();   
        }

        public virtual void Update(Starve g, GameTime gameTime)
        {
            
        }

        public virtual void Draw(Starve g)
        {

        }
    }
}
