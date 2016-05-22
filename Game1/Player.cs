using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    public class Player
    {

        public Texture2D PlayerTexture; //Animation representing the player

        public Vector2 Position; //Position of player

        public bool Active; //State of Player

        public int Health; 

        //Get the width of the player
        public int Width
        {
            get { return PlayerTexture.Width; }
        }

        //Get player height
        public int Height
        {
            get { return PlayerTexture.Height; }
        }

        public void initialize()
        {

        }

        public void Update()
        {

        }

        public void Draw()
        {

        }
    }
}
