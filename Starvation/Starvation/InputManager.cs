using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Input;

namespace Starvation
{
    public class InputManager
    {
        private KeyboardState previousState;
        private KeyboardState currentState;

        public InputManager()
        {
            currentState = Keyboard.GetState();

            previousState = currentState;
        }

        public void Update()
        {
            previousState = currentState;

            currentState = Keyboard.GetState();
        }

        public bool IsKeyPressed(Keys key)
        {
            if(currentState.IsKeyDown(key))
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
            
            if(previousState.IsKeyDown(key) && currentState.IsKeyUp(key))
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
