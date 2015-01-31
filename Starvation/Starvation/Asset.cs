using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;

namespace Starvation
{
    class Asset
    {
        public string AssetName { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Lenght { get; set; }
        public Vector2 Position { get; set; }

        public Asset(string name, int height, int width, int lenght, Vector2 position)
        {
            AssetName = name;
            Height = height;
            Width = width;
            Lenght = lenght;
            Position = position;
        }
    }
}
