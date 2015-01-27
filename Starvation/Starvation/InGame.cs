using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Starvation
{
    class InGame : IGameState
    {
        Player player = new Player();
        public void Load(ContentManager content)
        {
            player.Load(content);
        }

        public void Update(Starve g, GameTime gameTime)
        {
            player.Update(g, gameTime);
        }
        
        public void Draw(SpriteBatch spriteBatch)
        {
            player.Draw(spriteBatch);
        }
    }
}
