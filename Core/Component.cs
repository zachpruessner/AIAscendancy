using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace AIAscendancy.Core;

internal abstract class Component
{
    internal abstract void LoadContent(ContentManager Content);
    internal abstract void Update(GameTime gameTime, Game1 game);
    internal abstract void Draw(SpriteBatch spriteBatch);
}
