using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using H.XamlExtensions.Apps.Views;

namespace H.XamlExtensions.Apps;

public class App : Application
{
    public override void Initialize()
    {
#if DEBUG
        GC.KeepAlive(typeof(GridExtensions));
#endif

        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainView();
        }

        base.OnFrameworkInitializationCompleted();
    }
}
