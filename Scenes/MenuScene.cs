using AIAscendancy.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace AIAscendancy.Scenes;

internal class MenuScene : Component
{
    private Texture2D campaignButton;
    private Vector2 buttonPos1 = new Vector2 (50, (Data.ScreenHeight / 5) + 25);
    private Texture2D settingsButton;
    private Vector2 buttonPos2 = new Vector2 (50, (Data.ScreenHeight * 2 / 5) + 25);
    private Texture2D quitButton;
    private Vector2 buttonPos3 = new Vector2 (50, (Data.ScreenHeight * 3 / 5) + 25);
    private Texture2D menuBackground;
    private Rectangle menuBackgroundRect = new Rectangle(0, 0, Data.ScreenWidth, Data.ScreenHeight);

    internal override void LoadContent(ContentManager Content)
    {
        menuBackground = Content.Load<Texture2D>("menuBackground");
        campaignButton = Content.Load<Texture2D>("campaignButton");
        settingsButton = Content.Load<Texture2D>("settingsButton");
        quitButton = Content.Load<Texture2D>("quitButton");
    }

    internal override void Update(GameTime gameTime)
    {
    }

    internal override void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(menuBackground, menuBackgroundRect, Color.White);
        spriteBatch.Draw(campaignButton, buttonPos1,  Color.White);
        spriteBatch.Draw(settingsButton, buttonPos2,  Color.White);
        spriteBatch.Draw(quitButton, buttonPos3,  Color.White);
    }
}
