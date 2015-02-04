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
    class Player : IEntity
    {
        public Vector2 Position { get; set; }

        public string tag = "Player";

        private string AssetName { get; set; }
        private Texture2D playerSprite;

        public void Load(Starve g)
        {
            Position = new Vector2(10, 10);

            AssetName = "Player";
            playerSprite = g.Content.Load<Texture2D>(AssetName);
        }

        public void Update(Starve g, GameTime gameTime)
        {
            Input(g);

            
        }

        private void Input(Starve g)
        {

            if (g.InManager.IsKeyPressed(Keys.W))
            {
                Position = new Vector2(Position.X, Position.Y - 10);
            }

            if (g.InManager.IsKeyPressed(Keys.A))
            {
                Position = new Vector2(Position.X - 10, Position.Y);
            }

            if (g.InManager.IsKeyPressed(Keys.S))
            {
                Position = new Vector2(Position.X, Position.Y + 10);
            }

            if (g.InManager.IsKeyPressed(Keys.D))
            {
                Position = new Vector2(Position.X + 10, Position.Y);
            }


            
        }

        public void Draw(Starve g)
        {
            g.spriteBatch.Draw(playerSprite, Position, Color.White);
        }
    }
}
