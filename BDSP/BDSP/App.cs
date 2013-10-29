using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Nyan
{
    public class App : Microsoft.Xna.Framework.Game
    {
        readonly GraphicsDeviceManager _graphics;
        SpriteBatch _spriteBatch;

        private Background _background; // US
        private Character _character; // US

        public App()
        {
            _graphics = new GraphicsDeviceManager(this)
                {
                    PreferredBackBufferHeight = 338,
                    PreferredBackBufferWidth = 900
                };

            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            Texture2D backgroundTexture = Content.Load<Texture2D>("Background"); // US
            _background = new Background(backgroundTexture); // US

            Texture2D characterTexture = Content.Load<Texture2D>("Character"); // US
            _character = new Character(characterTexture); // US

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            _background.Update(gameTime); // US
            _character.Update(gameTime); // US

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin(); // US

            _background.Draw(_spriteBatch); // US
            _character.Draw(_spriteBatch); // US

            _spriteBatch.End(); // US

            base.Draw(gameTime);
        }
    }
}
