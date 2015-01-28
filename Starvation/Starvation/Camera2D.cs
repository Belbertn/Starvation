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
        public Vector2 Position { get { return position; } set { position = value; } }
        public float Rotation { get; set; }
        public Viewport Viewport { get; set; }

        private Vector2 position;

        private MouseState mState;
        private KeyboardState keyState;
        private Int32 scroll;

        public Camera2D(Viewport viewport)
        {
            Zoom = 1.0f;
            scroll = 1;
            Rotation = 0.0f;
            position = Vector2.Zero;
            Viewport = viewport;
        }

        public void Update(Starve g)
        {
            Input(g);

            Zoom = MathHelper.Clamp(Zoom, 0.0f, 10.0f);

            Rotation = ClampAngle(Rotation);

            Transform = Matrix.CreateRotationZ(Rotation) *
                            Matrix.CreateScale(new Vector3(Zoom, Zoom, 1)) *
                            Matrix.CreateTranslation(Position.X, Position.Y, 0);

            InverseTransform = Matrix.Invert(Transform);
        }

        public virtual void Input(Starve g)
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

            if(g.InManager.IsKeyPressed(Keys.Up))
            {
                position.Y += 10;
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

//#region Version History (1.0)
//// 03.07.11 ~ Created
//#endregion

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using Microsoft.Xna.Framework;
//using Microsoft.Xna.Framework.Graphics;
//using Microsoft.Xna.Framework.Input;

//namespace Starvation
//{
//    public class Camera2D
//    {
//        #region Fields

//        protected float zoom;
//        protected Matrix transform;
//        protected Matrix inverseTransform;
//        protected Vector2 pos;
//        protected float rotation;
//        protected Viewport viewport;
//        protected MouseState mState;
//        protected KeyboardState keyState;
//        protected Int32 scroll;

//        #endregion

//        #region Properties

//        public float Zoom
//        {
//            get { return zoom; }
//            set { zoom = value; }
//        }
//        /// <summary>
//        /// Camera View Matrix Property
//        /// </summary>
//        public Matrix Transform
//        {
//            get { return transform; }
//            set { transform = value; }
//        }
//        /// <summary>
//        /// Inverse of the view matrix, can be used to get objects screen coordinates
//        /// from its object coordinates
//        /// </summary>
//        public Matrix InverseTransform
//        {
//            get { return inverseTransform; }
//        }
//        public Vector2 Pos
//        {
//            get { return pos; }
//            set { pos = value; }
//        }
//        public float Rotation
//        {
//            get { return rotation; }
//            set { rotation = value; }
//        }

//        #endregion

//        #region Constructor

//        public Camera2D(Viewport viewport)
//        {
//            zoom = 1.0f;
//            scroll = 1;
//            rotation = 0.0f;
//            pos = Vector2.Zero;
//            this.viewport = viewport;
//        }

//        #endregion

//        #region Methods

//        /// <summary>
//        /// Update the camera view
//        /// </summary>
//        public void Update()
//        {
//            //Call Camera Input
//            Input();
//            //Clamp zoom value
//            zoom = MathHelper.Clamp(zoom, 0.0f, 10.0f);
//            //Clamp rotation value
//            rotation = ClampAngle(rotation);
//            //Create view matrix
//            transform =    Matrix.CreateRotationZ(rotation) * 
//                            Matrix.CreateScale(new Vector3(zoom, zoom, 1)) * 
//                            Matrix.CreateTranslation(pos.X, pos.Y, 0);
//            //Update inverse matrix
//            inverseTransform = Matrix.Invert(transform);
//        }

//        /// <summary>
//        /// Example Input Method, rotates using cursor keys and zooms using mouse wheel
//        /// </summary>
//        protected virtual void Input()
//        {
//            mState = Mouse.GetState();
//            keyState = Keyboard.GetState();
//            //Check zoom
//            if (mState.ScrollWheelValue > scroll)
//            {
//                zoom += 0.1f;
//                scroll = mState.ScrollWheelValue;
//            }
//            else if (mState.ScrollWheelValue < scroll)
//            {
//                zoom -= 0.1f;
//                scroll = mState.ScrollWheelValue;
//            }
//            //Check rotation
//            if (keyState.IsKeyDown(Keys.Left))
//            {
//                rotation -= 0.1f;
//            }
//            if (keyState.IsKeyDown(Keys.Right))
//            {
//                rotation += 0.1f;
//            }
//            //Check Move
//            if (keyState.IsKeyDown(Keys.A))
//            {
//                pos.X += 0.5f;
//            }
//            if (keyState.IsKeyDown(Keys.D))
//            {
//                pos.X -= 0.5f;
//            }
//            if (keyState.IsKeyDown(Keys.Up))
//            {
//                pos.Y += 0.5f;
//            }
//            if (keyState.IsKeyDown(Keys.Down))
//            {
//                pos.Y -= 0.5f;
//            }

//            Console.WriteLine(pos);
//        }

//        /// <summary>
//        /// Clamps a radian value between -pi and pi
//        /// </summary>
//        /// <param name="radians">angle to be clamped</param>
//        /// <returns>clamped angle</returns>
//        protected float ClampAngle(float radians)
//        {
//            while (radians < -MathHelper.Pi)
//            {
//                radians += MathHelper.TwoPi;
//            }
//            while (radians > MathHelper.Pi)
//            {
//                radians -= MathHelper.TwoPi;
//            }
//            return radians;
//        }

//        #endregion
//    }
//}


