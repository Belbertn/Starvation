using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Starvation
{
    class Asset
    {
        public string AssetName { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Lenght { get; set; }

        public Asset(string name, int height, int width, int lenght)
        {
            AssetName = name;
            Height = height;
            Width = width;
            Lenght = lenght;
        }
    }
}
