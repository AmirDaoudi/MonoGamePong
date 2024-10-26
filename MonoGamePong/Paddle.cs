using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace MonoGamePong
{
    internal class Paddle
    {
       
        Vector2 position
        {
            get 
            { 
                return rect.Location.ToVector2();
            }
            set
            {
                rect.Location = position.ToPoint();
            }
        }

        public int Width
        {

            get
            {
                return rect.Width;
            }

            set
            {
                rect.Width = Width;
            }
        }
        public int Height
        {

            get
            {
                return rect.Height;
            }

            set
            {
                rect.Height = Height;
            }
        }

        Rectangle rect;
        Texture2D texture;
        public Paddle( Vector2 position, Point size, Texture2D texture)
        {
            this.texture = texture;
            rect = new Rectangle((int)position.X, (int)position.Y, size.X, size.Y);
        }
        public void DrawPaddle(SpriteBatch _spriteBatch)
        {
           
            _spriteBatch.Draw(texture, rect, Color.White);
        }

    }
}

