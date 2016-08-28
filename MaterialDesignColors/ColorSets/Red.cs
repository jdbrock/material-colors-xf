using Xamarin.Forms;

namespace MaterialDesignColors
{
    public static class Red
    { 
        public static Color Primary50 { get; } = Color.FromHex("#FFEBEE");
        public static Color Primary100 { get; } = Color.FromHex("#FFCDD2");
        public static Color Primary200 { get; } = Color.FromHex("#EF9A9A");
        public static Color Primary300 { get; } = Color.FromHex("#E57373");
        public static Color Primary400 { get; } = Color.FromHex("#EF5350");
        public static Color Primary500 { get; } = Color.FromHex("#F44336");
        public static Color Primary600 { get; } = Color.FromHex("#E53935");
        public static Color Primary700 { get; } = Color.FromHex("#D32F2F");
        public static Color Primary800 { get; } = Color.FromHex("#C62828");
        public static Color Primary900 { get; } = Color.FromHex("#B71C1C");
        public static Color Accent100 { get; } = Color.FromHex("#FF8A80");
        public static Color Accent200 { get; } = Color.FromHex("#FF5252");
        public static Color Accent400 { get; } = Color.FromHex("#FF1744");
        public static Color Accent700 { get; } = Color.FromHex("#D50000");
        public static Color Primary50Foreground { get; } = Color.FromHex("#000000");
        public static Color Primary100Foreground { get; } = Color.FromHex("#000000");
        public static Color Primary200Foreground { get; } = Color.FromHex("#000000");
        public static Color Primary300Foreground { get; } = Color.FromHex("#000000");
        public static Color Primary400Foreground { get; } = Color.FromHex("#FFFFFF");
        public static Color Primary500Foreground { get; } = Color.FromHex("#FFFFFF");
        public static Color Primary600Foreground { get; } = Color.FromHex("#FFFFFF");
        public static Color Primary700Foreground { get; } = Color.FromHex("#FFFFFF");
        public static Color Primary800Foreground { get; } = Color.FromHex("#FFFFFF");
        public static Color Primary900Foreground { get; } = Color.FromHex("#FFFFFF");
        public static Color Accent100Foreground { get; } = Color.FromHex("#000000");
        public static Color Accent200Foreground { get; } = Color.FromHex("#FFFFFF");
        public static Color Accent400Foreground { get; } = Color.FromHex("#FFFFFF");
        public static Color Accent700Foreground { get; } = Color.FromHex("#FFFFFF");
        public static Color PrimaryHueLight { get; } = Primary200;
        public static Color PrimaryHueLightForeground { get; } = Primary200Foreground;
        public static Color PrimaryHueMid { get; } = Primary500;
        public static Color PrimaryHueMidForeground { get; } = Primary500Foreground;
        public static Color PrimaryHueDark { get; } = Primary700;
        public static Color PrimaryHueDarkForeground { get; } = Primary700Foreground;
        public static Color SecondaryAccent { get; } = Accent700;
        public static Color SecondaryAccentForeground { get; } = Accent700Foreground;
    }

    public class RedSet : IColorSet
    { 
        public Color Primary50 { get; } = Red.Primary50;
        public Color Primary100 { get; } = Red.Primary100;
        public Color Primary200 { get; } = Red.Primary200;
        public Color Primary300 { get; } = Red.Primary300;
        public Color Primary400 { get; } = Red.Primary400;
        public Color Primary500 { get; } = Red.Primary500;
        public Color Primary600 { get; } = Red.Primary600;
        public Color Primary700 { get; } = Red.Primary700;
        public Color Primary800 { get; } = Red.Primary800;
        public Color Primary900 { get; } = Red.Primary900;
        public Color Accent100 { get; } = Red.Accent100;
        public Color Accent200 { get; } = Red.Accent200;
        public Color Accent400 { get; } = Red.Accent400;
        public Color Accent700 { get; } = Red.Accent700;
        public Color Primary50Foreground { get; } = Red.Primary50Foreground;
        public Color Primary100Foreground { get; } = Red.Primary100Foreground;
        public Color Primary200Foreground { get; } = Red.Primary200Foreground;
        public Color Primary300Foreground { get; } = Red.Primary300Foreground;
        public Color Primary400Foreground { get; } = Red.Primary400Foreground;
        public Color Primary500Foreground { get; } = Red.Primary500Foreground;
        public Color Primary600Foreground { get; } = Red.Primary600Foreground;
        public Color Primary700Foreground { get; } = Red.Primary700Foreground;
        public Color Primary800Foreground { get; } = Red.Primary800Foreground;
        public Color Primary900Foreground { get; } = Red.Primary900Foreground;
        public Color Accent100Foreground { get; } = Red.Accent100Foreground;
        public Color Accent200Foreground { get; } = Red.Accent200Foreground;
        public Color Accent400Foreground { get; } = Red.Accent400Foreground;
        public Color Accent700Foreground { get; } = Red.Accent700Foreground;
        public Color PrimaryHueLight { get; } = Red.PrimaryHueLight;
        public Color PrimaryHueLightForeground { get; } = Red.PrimaryHueLightForeground;
        public Color PrimaryHueMid { get; } = Red.PrimaryHueMid;
        public Color PrimaryHueMidForeground { get; } = Red.PrimaryHueMidForeground;
        public Color PrimaryHueDark { get; } = Red.PrimaryHueDark;
        public Color PrimaryHueDarkForeground { get; } = Red.PrimaryHueDarkForeground;
        public Color SecondaryAccent { get; } = Red.SecondaryAccent;
        public Color SecondaryAccentForeground { get; } = Red.SecondaryAccentForeground;
    }
}