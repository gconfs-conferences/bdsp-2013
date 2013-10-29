using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Nyan
{
    class Character
    {
        private readonly Texture2D _texture;

        private Vector2 _position;

        public Character(Texture2D texture)
        {
            this._texture = texture;

            this._position = new Vector2(0, 166 - (_texture.Height/2));
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _position, Color.White);
        }

        public void Update(GameTime gameTime)
        {
            MouseState mouseState = Mouse.GetState();

            _position.Y = mouseState.Y;

            if (_position.Y < 0)
                _position.Y = 0;

            else if (_position.Y + _texture.Height > 338)
                _position.Y = 338 - _texture.Height;

            _position.X = mouseState.X - _texture.Width;

            if (_position.X > 0)
                _position.X = 0;
        }
    }
}
