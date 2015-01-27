using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Starvation
{  
    public class Camera2D
    {
        public float Zoom { get; set; }
        public Matrix Transform { get; set; }
        public Matrix InverseTransform { get; set; }
        public Vector2 Position { get; set; }
        public float Rotation { get; set; }
        public Viewport Viewport { get; set; }

        private MouseState mState;
        private KeyboardState keyState;
        private Int32 scroll;

        public Camera2D(Viewport viewport)
        {
            Zoom = 1.0f;
            scroll = 1;
            Rotation = 0.0f;
            Position = Vector2.Zero;
            Viewport = viewport;
        }

        public void Update()
        {
            Input();

            Zoom = MathHelper.Clamp(Zoom, 0.0f, 10.0f);

            Rotation = ClampAngle(Rotation);

            Transform = Matrix.CreateRotationZ(Rotation) *
                            Matrix.CreateScale(new Vector3(Zoom, Zoom, 1)) *
                            Matrix.CreateTranslation(Position.X, Position.Y, 0);

            InverseTransform = Matrix.Invert(Transform);
        }

        public virtual void Input()
        {
            mState = Mouse.GetState();
            keyState = Keyboard.GetState();

            if (mState.ScrollWheelValue > scroll)
            {
                Zoom += 0.1f;
                scroll = mState.ScrollWheelValue;
            }
            else if (mState.ScrollWheelValue < scroll)
            {
                Zoom -= 0.1f;
                scroll = mState.ScrollWheelValue;
            }
        }

        private float ClampAngle(float radians)
        {
            while (radians < -MathHelper.Pi)
            {
                radians += MathHelper.TwoPi;
            }
            while (radians > MathHelper.Pi)
            {
                radians -= MathHelper.TwoPi;
            }
            return radians;
        }

    }   
}
