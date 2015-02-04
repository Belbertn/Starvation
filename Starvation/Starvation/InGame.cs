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
        public List<IEntity> entities { get; set; }
        public void Load(Starve g)
        {
            entities = new List<IEntity>();
            entities.Add(new Player());

            entities.Add(new Tree());

            foreach(IEntity entity in entities)
            {
                entity.Load(g);
            }
        }

        public void Update(Starve g, GameTime gameTime)
        {
            foreach (IEntity entity in entities)
            {
                entity.Update(g, gameTime);
            }            
        }
        
        public void Draw(Starve g)
        {
            foreach (IEntity entity in entities)
            {
                entity.Draw(g);
            }
        }
    }
}
