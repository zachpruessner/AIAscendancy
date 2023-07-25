using AIAscendancy.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using AIAscendancy.UIElements;
using System.Collections.Generic;
using System;

namespace AIAscendancy.Scenes;

internal class MenuScene : Component
{
    private Texture2D campaignButton;
    private Texture2D campaignButtonHovered;
    private Texture2D campaignButtonPressed;
    private Rectangle campaignButtonRect = new Rectangle(50, (Data.ScreenHeight / 5) - 50, 300, 100);
    private Texture2D upgradeButton;
    private Texture2D upgradeButtonHovered;
    private Texture2D upgradeButtonPressed;
    private Rectangle upgradeButtonRect = new Rectangle(50, (Data.ScreenHeight * 2 / 5) - 50, 300, 100);
    private Texture2D settingsButton;
    private Texture2D settingsButtonHovered;
    private Texture2D settingsButtonPressed;
    private Rectangle settingsButtonRect = new Rectangle(50, (Data.ScreenHeight * 3 / 5) - 50, 300, 100);
    private Texture2D exitButton;
    private Texture2D exitButtonHovered;
    private Texture2D exitButtonPressed;
    private Rectangle exitButtonRect = new Rectangle(50, (Data.ScreenHeight * 4 / 5) - 50, 300, 100);
    private Texture2D yesButton;
    private Texture2D yesButtonHovered;
    private Texture2D yesButtonPressed;
    private Rectangle yesButtonRect = new Rectangle(315, 335, 300, 100);
    private Texture2D noButton;
    private Texture2D noButtonHovered;
    private Texture2D noButtonPressed;
    private Rectangle noButtonRect = new Rectangle(665, 335, 300, 100);
    private Texture2D menuBackground;
    private Rectangle menuBackgroundRect = new Rectangle(0, 0, Data.ScreenWidth, Data.ScreenHeight);
    private Texture2D quitPopup;
    private Rectangle quitPopupRect = new Rectangle(265, 260, 750, 200);
    private List<Button> _menuButtons;
    private List<Button> _popupButtons;
    private bool quitButtonPressed = false;


    public MenuScene()
    {
    }

    internal override void LoadContent(ContentManager Content)
    {
        menuBackground = Content.Load<Texture2D>("menuBackground");
        quitPopup = Content.Load<Texture2D>("quitPopup");
        campaignButton = Content.Load<Texture2D>("buttons/campaignButton");
        campaignButtonHovered = Content.Load<Texture2D>("buttons/campaignButtonHovered");
        campaignButtonPressed = Content.Load<Texture2D>("buttons/campaignButtonPressed");
        upgradeButton = Content.Load<Texture2D>("buttons/upgradeButton");
        upgradeButtonHovered = Content.Load<Texture2D>("buttons/upgradeButtonHovered");
        upgradeButtonPressed = Content.Load<Texture2D>("buttons/upgradeButtonPressed");
        settingsButton = Content.Load<Texture2D>("buttons/settingsButton");
        settingsButtonHovered = Content.Load<Texture2D>("buttons/settingsButtonHovered");
        settingsButtonPressed = Content.Load<Texture2D>("buttons/settingsButtonPressed");
        exitButton = Content.Load<Texture2D>("buttons/exitButton");
        exitButtonHovered = Content.Load<Texture2D>("buttons/exitButtonHovered");
        exitButtonPressed = Content.Load<Texture2D>("buttons/exitButtonPressed");
        yesButton = Content.Load<Texture2D>("buttons/yesButton");
        yesButtonHovered = Content.Load<Texture2D>("buttons/yesButtonHovered");
        yesButtonPressed = Content.Load<Texture2D>("buttons/yesButtonPressed");
        noButton = Content.Load<Texture2D>("buttons/noButton");
        noButtonHovered = Content.Load<Texture2D>("buttons/noButtonHovered");
        noButtonPressed = Content.Load<Texture2D>("buttons/noButtonPressed");

        _menuButtons = new List<Button>
        {
            new Button(campaignButtonRect, campaignButton, campaignButtonHovered, campaignButtonPressed),
            new Button(upgradeButtonRect, upgradeButton, upgradeButtonHovered, upgradeButtonPressed),
            new Button(settingsButtonRect, settingsButton, settingsButtonHovered, settingsButtonPressed),
            new Button(exitButtonRect, exitButton, exitButtonHovered, exitButtonPressed),

        };

        _popupButtons = new List<Button>
        {
            new Button(yesButtonRect, yesButton, yesButtonHovered, yesButtonPressed),
            new Button(noButtonRect, noButton, noButtonHovered, noButtonPressed),
        };
    }

    internal override void Update(GameTime gameTime, Game1 game)
    {
        var mouseState = Mouse.GetState();

        foreach (var button in _menuButtons)
            button.Update(mouseState);

        if (_menuButtons[3].State == Button.StateEnum.Pressed) quitButtonPressed = true;

        if (quitButtonPressed)
        {
            foreach (var button in _popupButtons)
                button.Update(mouseState);

            if (_popupButtons[0].State == Button.StateEnum.Pressed) game.Exit();
            if (_popupButtons[1].State == Button.StateEnum.Pressed) quitButtonPressed = false;
        }

    }

    internal override void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(menuBackground, menuBackgroundRect, Color.White);

        foreach (var button in _menuButtons)
            button.Draw(spriteBatch);

        if (quitButtonPressed)
        {
            spriteBatch.Draw(quitPopup, quitPopupRect, Color.White);

            foreach (var button in _popupButtons)
                button.Draw(spriteBatch);
        }
    }
}
