using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Starvation
{
    class AssetManager
    {
        public Texture2D SpriteSheet { get; set; }
        private List<Asset> assets = new List<Asset>();

        public void Load(Starve g)
        {
            SpriteSheet = g.Content.Load<Texture2D>("SpriteSheet");

            CreateAssets(DivideLines());
        }

        private string[] DivideLines()
        {
            string[] lines = null;
            try
            {
                using (StreamReader sr = new StreamReader("SpriteCoords.txt"))
                {
                    string line = sr.ReadToEnd();
                    lines = line.Split('\n');
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Could not load file");
                Console.WriteLine(e.Message);
            }
            return lines;
        }

        private void CreateAssets(string[] lines)
        {
            for(int i = 0; i < lines.Length - 1; i++)
            {
                string[] properties = lines[i].Split(',');
                string name = "";
                int height = 0;
                int width = 0;
                int length = 0;
                float xPos = 0.0f;
                float yPos = 0.0f;

                for(int j = 0; j < properties.Length - 1; j++)
                {
                    name = properties[0];
                    height = Convert.ToInt32(properties[1]);
                    width = Convert.ToInt32(properties[2]);
                    length = Convert.ToInt32(properties[3]);
                    xPos = Convert.ToSingle(properties[4]);
                    yPos = Convert.ToSingle(properties[5]);
                }

                assets.Add(new Asset(name, height, width, length, new Vector2(xPos, yPos)));
            }
        }

        public Asset GetAssetData(string assetName)
        {
            Asset asset = null;

            foreach(Asset a in assets)
            {
                if (a.AssetName == assetName)
                {
                    asset = a;
                }
            }

            return asset;
        }
    }
}
