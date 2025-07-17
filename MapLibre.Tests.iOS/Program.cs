using UIKit;

namespace MapLibre.Tests.iOS;

public class Program
{
    // This is the main entry point of the application.
    static void Main(string[] args)
    {
        // Use the type-safe overload instead of string
        UIApplication.Main(args, null, typeof(AppDelegate));
    }
}

public class AppDelegate : UIApplicationDelegate
{
    public override UIWindow? Window { get; set; }

    public override bool FinishedLaunching(UIApplication application, NSDictionary? launchOptions)
    {
        // Override point for customization after application launch.
        return true;
    }
}
