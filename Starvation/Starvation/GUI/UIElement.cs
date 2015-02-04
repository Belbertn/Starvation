﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Starvation.GUI
{
    abstract class UIElement 
    {
        public Texture2D texture { get; set; }
        public Vector2 Position { get; set; }

        public AssetManager assetManager { get; set; }

        public virtual void Load()
        {
            assetManager = new AssetManager();

            
        }
    }
}
