using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Input;

namespace Starvation
{
    class InputManager
    {
        private Keys[] previousState;
        private Keys[] currentState;

        public void Initialize()
        {
            previousState = new KeyboardState().GetPressedKeys();
        }

        public void Update()
        {
            currentState = new KeyboardState().GetPressedKeys();


            previousState = currentState;
        }

        public bool IsKeyPressed(Keys key)
        {
            if(currentState.Contains<Keys>(key))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool WasKeyPressed(Keys key)
        {
            if(previousState.Contains<Keys>(key))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
