using AIAscendancy.Core;
using AIAscendancy.Scenes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace AIAscendancy.Managers;

internal partial class GameStateManager : Component
{
    private MenuScene menuScene = new MenuScene();
    private GameScene gameScene = new GameScene();

    internal override void LoadContent(ContentManager Content)
    {
        menuScene.LoadContent(Content);
        gameScene.LoadContent(Content);
    }

    internal override void Update(GameTime gameTime, Game1 game)
    {
        switch (Data.CurrentState)
        {
            case Data.Scenes.Menu:
                menuScene.Update(gameTime, game);
                break;
            case Data.Scenes.Game:
                gameScene.Update(gameTime, game);
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
                menuScene.Draw(spriteBatch);
                break;
            case Data.Scenes.Game:
                gameScene.Draw(spriteBatch);
                break;
            case Data.Scenes.Settings:
                break;
        }
    }
}
