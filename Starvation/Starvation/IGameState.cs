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
    interface IGameState
    {
        void Load(ContentManager content);
        void Update(Starve g, GameTime gameTime);
        void Draw(SpriteBatch spriteBatch);
    }
}
