using Xamarin.Forms;

namespace MaterialDesignColors
{
    public static class Blue
    { 
        public static Color Primary50 { get; } = Color.FromHex("#E3F2FD");
        public static Color Primary100 { get; } = Color.FromHex("#BBDEFB");
        public static Color Primary200 { get; } = Color.FromHex("#90CAF9");
        public static Color Primary300 { get; } = Color.FromHex("#64B5F6");
        public static Color Primary400 { get; } = Color.FromHex("#42A5F5");
        public static Color Primary500 { get; } = Color.FromHex("#2196F3");
        public static Color Primary600 { get; } = Color.FromHex("#1E88E5");
        public static Color Primary700 { get; } = Color.FromHex("#1976D2");
        public static Color Primary800 { get; } = Color.FromHex("#1565C0");
        public static Color Primary900 { get; } = Color.FromHex("#0D47A1");
        public static Color Accent100 { get; } = Color.FromHex("#82B1FF");
        public static Color Accent200 { get; } = Color.FromHex("#448AFF");
        public static Color Accent400 { get; } = Color.FromHex("#2979FF");
        public static Color Accent700 { get; } = Color.FromHex("#2962FF");
        public static Color Primary50Foreground { get; } = Color.FromHex("#000000");
        public static Color Primary100Foreground { get; } = Color.FromHex("#000000");
        public static Color Primary200Foreground { get; } = Color.FromHex("#000000");
        public static Color Primary300Foreground { get; } = Color.FromHex("#000000");
        public static Color Primary400Foreground { get; } = Color.FromHex("#000000");
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

    public class BlueSet : IColorSet
    { 
        public Color Primary50 { get; } = Blue.Primary50;
        public Color Primary100 { get; } = Blue.Primary100;
        public Color Primary200 { get; } = Blue.Primary200;
        public Color Primary300 { get; } = Blue.Primary300;
        public Color Primary400 { get; } = Blue.Primary400;
        public Color Primary500 { get; } = Blue.Primary500;
        public Color Primary600 { get; } = Blue.Primary600;
        public Color Primary700 { get; } = Blue.Primary700;
        public Color Primary800 { get; } = Blue.Primary800;
        public Color Primary900 { get; } = Blue.Primary900;
        public Color Accent100 { get; } = Blue.Accent100;
        public Color Accent200 { get; } = Blue.Accent200;
        public Color Accent400 { get; } = Blue.Accent400;
        public Color Accent700 { get; } = Blue.Accent700;
        public Color Primary50Foreground { get; } = Blue.Primary50Foreground;
        public Color Primary100Foreground { get; } = Blue.Primary100Foreground;
        public Color Primary200Foreground { get; } = Blue.Primary200Foreground;
        public Color Primary300Foreground { get; } = Blue.Primary300Foreground;
        public Color Primary400Foreground { get; } = Blue.Primary400Foreground;
        public Color Primary500Foreground { get; } = Blue.Primary500Foreground;
        public Color Primary600Foreground { get; } = Blue.Primary600Foreground;
        public Color Primary700Foreground { get; } = Blue.Primary700Foreground;
        public Color Primary800Foreground { get; } = Blue.Primary800Foreground;
        public Color Primary900Foreground { get; } = Blue.Primary900Foreground;
        public Color Accent100Foreground { get; } = Blue.Accent100Foreground;
        public Color Accent200Foreground { get; } = Blue.Accent200Foreground;
        public Color Accent400Foreground { get; } = Blue.Accent400Foreground;
        public Color Accent700Foreground { get; } = Blue.Accent700Foreground;
        public Color PrimaryHueLight { get; } = Blue.PrimaryHueLight;
        public Color PrimaryHueLightForeground { get; } = Blue.PrimaryHueLightForeground;
        public Color PrimaryHueMid { get; } = Blue.PrimaryHueMid;
        public Color PrimaryHueMidForeground { get; } = Blue.PrimaryHueMidForeground;
        public Color PrimaryHueDark { get; } = Blue.PrimaryHueDark;
        public Color PrimaryHueDarkForeground { get; } = Blue.PrimaryHueDarkForeground;
        public Color SecondaryAccent { get; } = Blue.SecondaryAccent;
        public Color SecondaryAccentForeground { get; } = Blue.SecondaryAccentForeground;
    }
}