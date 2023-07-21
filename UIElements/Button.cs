using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace AIAscendancy.UIElements;

public class Button
{
    public enum StateEnum
    {
        None,
        Pressed,
        Hovered,
        Released
    }

    private Rectangle _rectangle;
    private StateEnum _state;
    public StateEnum State {
        get { return _state; }
        set { _state = value; }
    }

    private Dictionary<StateEnum, Texture2D> _textures;
    
    public Button(Rectangle rectangle, Texture2D noneTexture, Texture2D hoverTexture, Texture2D pressedTexture)
    {
        _rectangle = rectangle;
        _textures = new Dictionary<StateEnum, Texture2D>
        {
            { StateEnum.None, noneTexture },
            { StateEnum.Hovered, hoverTexture },
            { StateEnum.Pressed, pressedTexture },
            { StateEnum.Released, hoverTexture }
        };
    }

    public void Update(MouseState mouseState)
    {
        if (!_rectangle.Contains(mouseState.X, mouseState.Y))
        {
            State = StateEnum.None;
            return;
        }
        
        if (_rectangle.Contains(mouseState.X, mouseState.Y) && mouseState.LeftButton == ButtonState.Pressed)
            State = StateEnum.Pressed;
        else
            State = State == StateEnum.Pressed ? StateEnum.Released : StateEnum.Hovered;
    }

    public void Draw(SpriteBatch spriteBatch) 
    {
        spriteBatch.Draw(_textures[State], _rectangle, Color.White);
    }
}