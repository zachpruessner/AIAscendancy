using AIAscendancy.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace AIAscendancy.Scenes;

internal class MenuScene : Component
{
    private const int MAX_BUTTONS = 3;
    private Texture2D[] buttons = new Texture2D[3];
    private Rectangle[] buttonRectangles = new Rectangle[3];

    internal override void LoadContent(ContentManager Content)
    {
        const int INCREMENT_VALUE = 175;
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i] = Content.Load<Texture2D>($"menuButton{i}");

            buttonRectangles[i] = new Rectangle(0, 125 + (INCREMENT_VALUE * i), buttons[i].Width, buttons[i].Height);
        }
    }

    internal override void Update(GameTime gameTime)
    {
    }

    internal override void Draw(SpriteBatch spriteBatch)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            spriteBatch.Draw(buttons[i], buttonRectangles[i], Color.White);
        }
    }
}
