using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Nyan
{
    class Background
    {
        private readonly Texture2D _texture;
        private readonly int _width;
        private int _positionX;

        public Background(Texture2D texture)
        {
            _texture = texture;
            _width = texture.Width;
            _positionX = 0;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, new Vector2(_positionX, 0), Color.White);

            int textureEnd = _positionX + _width;

            if (textureEnd < 900)
                spriteBatch.Draw(_texture, new Vector2(textureEnd, 0), Color.White);
        }

        public void Update(GameTime gameTime)
        {
            _positionX -= 5;
            if (_positionX <= _width)
                _positionX %= _width;
        }
    }
}
