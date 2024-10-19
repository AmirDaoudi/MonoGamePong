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
        int right, top, moveSpeed;
        int WIDTH, Height;
        Vector2 pixel;
        Rectangle rect;
        Texture2D texture;
        public Paddle(int WIDTH, int HEIGHT, Vector2 pixel, Texture2D texture)
        {
            this.WIDTH = WIDTH;
            this.Height = HEIGHT;
            this.pixel = pixel;
            this.texture = texture;
            rect = new Rectangle(WIDTH / 2 - 20, HEIGHT / 2 - 20, 40, 40);
        }
        public void DrawPaddle(SpriteBatch _spriteBatch)
        {
           
            _spriteBatch.Draw(texture, rect, Color.White);
        }

    }
}

