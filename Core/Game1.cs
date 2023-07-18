using AIAscendancy.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace AIAscendancy.Core;

public class Game1 : Game
{
    public static GraphicsDeviceManager graphics;
    private SpriteBatch spriteBatch;
    private GameStateManager gameStateManager;

    public Game1()
    {
        graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        graphics.PreferredBackBufferWidth = Data.ScreenWidth;
        graphics.PreferredBackBufferHeight = Data.ScreenHeight;
        graphics.ApplyChanges();

        gameStateManager = new GameStateManager();

        base.Initialize();
    }

    protected override void LoadContent()
    {
        spriteBatch = new SpriteBatch(GraphicsDevice);
        gameStateManager.LoadContent(Content);
    }

    protected override void Update(GameTime gameTime)
    {
        gameStateManager.Update(gameTime);
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        spriteBatch.Begin();
        gameStateManager.Draw(spriteBatch);
        spriteBatch.End();

        base.Draw(gameTime);
    }
}
