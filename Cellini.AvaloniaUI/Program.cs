using Avalonia;

namespace Cellini.AvaloniaUI;

internal static class Program
{
    // Avalonia types must not be touched before AppMain is called, as they are not initialized yet
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);

    // Also used by the visual designer
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .LogToTrace();
}
