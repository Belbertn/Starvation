using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Starvation.GUI
{
    interface IUserInterface
    {
        Rectangle area { get; set; }
        Vector2 Position { get; set; }
        void Update(Starve g, GameTime gameTime);
        void Draw(SpriteBatch spriteBatch);
    }
}
