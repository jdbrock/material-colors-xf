using Xamarin.Forms;

namespace MaterialDesignColors
{
    public static class BlueGrey
    { 
        public static Color Primary50 { get; } = Color.FromHex("#ECEFF1");
        public static Color Primary100 { get; } = Color.FromHex("#CFD8DC");
        public static Color Primary200 { get; } = Color.FromHex("#B0BEC5");
        public static Color Primary300 { get; } = Color.FromHex("#90A4AE");
        public static Color Primary400 { get; } = Color.FromHex("#78909C");
        public static Color Primary500 { get; } = Color.FromHex("#607D8B");
        public static Color Primary600 { get; } = Color.FromHex("#546E7A");
        public static Color Primary700 { get; } = Color.FromHex("#455A64");
        public static Color Primary800 { get; } = Color.FromHex("#37474F");
        public static Color Primary900 { get; } = Color.FromHex("#263238");
        public static Color Accent100 { get; } = Color.FromHex("#000000");
        public static Color Accent200 { get; } = Color.FromHex("#000000");
        public static Color Accent400 { get; } = Color.FromHex("#000000");
        public static Color Accent700 { get; } = Color.FromHex("#000000");
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
        public static Color Accent200Foreground { get; } = Color.FromHex("#000000");
        public static Color Accent400Foreground { get; } = Color.FromHex("#000000");
        public static Color Accent700Foreground { get; } = Color.FromHex("#000000");
        public static Color PrimaryHueLight { get; } = Primary200;
        public static Color PrimaryHueLightForeground { get; } = Primary200Foreground;
        public static Color PrimaryHueMid { get; } = Primary500;
        public static Color PrimaryHueMidForeground { get; } = Primary500Foreground;
        public static Color PrimaryHueDark { get; } = Primary700;
        public static Color PrimaryHueDarkForeground { get; } = Primary700Foreground;
        public static Color SecondaryAccent { get; } = Accent700;
        public static Color SecondaryAccentForeground { get; } = Accent700Foreground;
    }

    public class BlueGreySet : IColorSet
    { 
        public Color Primary50 { get; } = BlueGrey.Primary50;
        public Color Primary100 { get; } = BlueGrey.Primary100;
        public Color Primary200 { get; } = BlueGrey.Primary200;
        public Color Primary300 { get; } = BlueGrey.Primary300;
        public Color Primary400 { get; } = BlueGrey.Primary400;
        public Color Primary500 { get; } = BlueGrey.Primary500;
        public Color Primary600 { get; } = BlueGrey.Primary600;
        public Color Primary700 { get; } = BlueGrey.Primary700;
        public Color Primary800 { get; } = BlueGrey.Primary800;
        public Color Primary900 { get; } = BlueGrey.Primary900;
        public Color Accent100 { get; } = BlueGrey.Accent100;
        public Color Accent200 { get; } = BlueGrey.Accent200;
        public Color Accent400 { get; } = BlueGrey.Accent400;
        public Color Accent700 { get; } = BlueGrey.Accent700;
        public Color Primary50Foreground { get; } = BlueGrey.Primary50Foreground;
        public Color Primary100Foreground { get; } = BlueGrey.Primary100Foreground;
        public Color Primary200Foreground { get; } = BlueGrey.Primary200Foreground;
        public Color Primary300Foreground { get; } = BlueGrey.Primary300Foreground;
        public Color Primary400Foreground { get; } = BlueGrey.Primary400Foreground;
        public Color Primary500Foreground { get; } = BlueGrey.Primary500Foreground;
        public Color Primary600Foreground { get; } = BlueGrey.Primary600Foreground;
        public Color Primary700Foreground { get; } = BlueGrey.Primary700Foreground;
        public Color Primary800Foreground { get; } = BlueGrey.Primary800Foreground;
        public Color Primary900Foreground { get; } = BlueGrey.Primary900Foreground;
        public Color Accent100Foreground { get; } = BlueGrey.Accent100Foreground;
        public Color Accent200Foreground { get; } = BlueGrey.Accent200Foreground;
        public Color Accent400Foreground { get; } = BlueGrey.Accent400Foreground;
        public Color Accent700Foreground { get; } = BlueGrey.Accent700Foreground;
        public Color PrimaryHueLight { get; } = BlueGrey.PrimaryHueLight;
        public Color PrimaryHueLightForeground { get; } = BlueGrey.PrimaryHueLightForeground;
        public Color PrimaryHueMid { get; } = BlueGrey.PrimaryHueMid;
        public Color PrimaryHueMidForeground { get; } = BlueGrey.PrimaryHueMidForeground;
        public Color PrimaryHueDark { get; } = BlueGrey.PrimaryHueDark;
        public Color PrimaryHueDarkForeground { get; } = BlueGrey.PrimaryHueDarkForeground;
        public Color SecondaryAccent { get; } = BlueGrey.SecondaryAccent;
        public Color SecondaryAccentForeground { get; } = BlueGrey.SecondaryAccentForeground;
    }
}