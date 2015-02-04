﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Starvation
{
    class Tree : IEntity
    {
        public Vector2 Position { get; set; }

        public string tag = "Tree";

        private string AssetName { get; set; }
        private Texture2D treeSprite;

        public void Load(Starve g)
        {
            Position = new Vector2(40, 40);

            AssetName = "Tree";
            treeSprite = g.Content.Load<Texture2D>(AssetName);
        }

        public void Update(Starve g, GameTime gameTime)
        {

        }

        public void Draw(Starve g)
        {
            g.spriteBatch.Draw(treeSprite, Position, Color.White);
        }
    }
}
