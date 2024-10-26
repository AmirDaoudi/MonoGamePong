using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace MonoGamePong
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;


        Ball boll;
        Paddle leftPaddle;
        Paddle rightPaddle;
        int paddleWidth = 25;
        int paddleHeight = 125;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }
        //Note from last class on october 19th finish making the paddles move and add the working ball
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            Texture2D texture = Content.Load<Texture2D>("Red-Ball-PNG-Image");
            Texture2D paddleTexture = Content.Load<Texture2D>("images");
            Vector2 leftPaddleLocation = new Vector2(0, GraphicsDevice.Viewport.Height/8);
            Vector2 rightPaddleLocation = new Vector2(GraphicsDevice.Viewport.Width - paddleWidth, GraphicsDevice.Viewport.Height/8);
            Point PaddleSize = new Point(25, 125);
            leftPaddle = new Paddle(leftPaddleLocation, PaddleSize, paddleTexture);
            rightPaddle = new Paddle(rightPaddleLocation, PaddleSize, paddleTexture);
            rect = new Rectangle(350, 200, 50, 50);
            // TODO: use this.Content to load your game content here
            //NOTE FROM 10-12 FINISH FIXING HERE
            Console.WriteLine(GraphicsDevice.Viewport.Width);
            Console.WriteLine(GraphicsDevice.Viewport.Height);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
           
            KeyboardState state = Keyboard.GetState();
            if (state.IsKeyDown(Keys.A))
            {
                rightPaddleLocation.X += 5;
            }
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            _spriteBatch.Draw(texture, rect, Color.White);
            leftPaddle.DrawPaddle(_spriteBatch);
            rightPaddle.DrawPaddle(_spriteBatch);
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
