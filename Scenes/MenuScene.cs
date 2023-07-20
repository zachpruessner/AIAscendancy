using AIAscendancy.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace AIAscendancy.Scenes;

internal class MenuScene : Component
{
    private Texture2D campaignButton;
    private Vector2 buttonPos1 = new Vector2 (50, Data.ScreenHeight / 5);
    private Texture2D settingsButton;
    private Vector2 buttonPos2 = new Vector2 (50, Data.ScreenHeight * 2 / 5);
    private Texture2D quitButton;
    private Vector2 buttonPos3 = new Vector2 (50, Data.ScreenHeight * 3 / 5);
    private Texture2D shuttle;
    private Vector2 shuttlePos = new Vector2 (Data.ScreenWidth / 2, Data.ScreenHeight  / 2);

    internal override void LoadContent(ContentManager Content)
    {
        campaignButton = Content.Load<Texture2D>("campaignButton");
        settingsButton = Content.Load<Texture2D>("settingsButton");
        quitButton = Content.Load<Texture2D>("quitButton");
        shuttle = Content.Load<Texture2D>("shuttle");
    }

    internal override void Update(GameTime gameTime)
    {
    }

    internal override void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(campaignButton, buttonPos1,  Color.White);
        spriteBatch.Draw(settingsButton, buttonPos2,  Color.White);
        spriteBatch.Draw(quitButton, buttonPos3,  Color.White);
        spriteBatch.Draw(shuttle, shuttlePos, Color.White);
    }
}
