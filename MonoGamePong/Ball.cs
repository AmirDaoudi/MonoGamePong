using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGamePong
{
    internal class Ball
    {
        int right, top, moveSpeed;
        int WIDTH, Height;
        Vector2 pixel;
        Rectangle rect;
        public Ball(int WIDTH, int HEIGHT, Rectangle rect, Vector2 pixel)
        {
            this.WIDTH = WIDTH;
            this.Height = HEIGHT;
            this.pixel = pixel;
            this.rect = rect;
            rect = new Rectangle(WIDTH / 2 - 20, HEIGHT / 2 - 20, 40, 40);
        }
        public void Draw(Vector2 pixel, Vector2 rect)
        {

        }

    }
}
