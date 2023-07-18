namespace AIAscendancy.Core;

public static class Data
{
    public static int ScreenWidth { get; set; } = 1280;
    public static int ScreenHeight { get; set; } = 720;
    public static bool Exit { get; set; } = false;
    public enum Scenes {Menu, Game, Settings};
    public static Scenes CurrentState { get; set; } = Scenes.Menu;
}