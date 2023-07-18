using AIAscendancy.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace AIAscendancy.Managers;

internal partial class GameStateManager : Component
{

    internal override void LoadContent(ContentManager Content)
    {
    }

    internal override void Update(GameTime gameTime)
    {
        switch (Data.CurrentState)
        {
            case Data.Scenes.Menu:
                break;
            case Data.Scenes.Game:
                break;
            case Data.Scenes.Settings:
                break;
        }
    }

    internal override void Draw(SpriteBatch spriteBatch)
    {
        switch (Data.CurrentState)
        {
            case Data.Scenes.Menu:
                break;
            case Data.Scenes.Game:
                break;
            case Data.Scenes.Settings:
                break;
        }
    }
}