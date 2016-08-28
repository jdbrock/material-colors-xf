using Xamarin.Forms;

namespace MaterialDesignColors
{
    public static class Grey
    { 
        public static Color Primary50 { get; } = Color.FromHex("#FAFAFA");
        public static Color Primary100 { get; } = Color.FromHex("#F5F5F5");
        public static Color Primary200 { get; } = Color.FromHex("#EEEEEE");
        public static Color Primary300 { get; } = Color.FromHex("#E0E0E0");
        public static Color Primary400 { get; } = Color.FromHex("#BDBDBD");
        public static Color Primary500 { get; } = Color.FromHex("#9E9E9E");
        public static Color Primary600 { get; } = Color.FromHex("#757575");
        public static Color Primary700 { get; } = Color.FromHex("#616161");
        public static Color Primary800 { get; } = Color.FromHex("#424242");
        public static Color Primary900 { get; } = Color.FromHex("#212121");
        public static Color Accent100 { get; } = Color.FromHex("#000000");
        public static Color Accent200 { get; } = Color.FromHex("#000000");
        public static Color Accent400 { get; } = Color.FromHex("#000000");
        public static Color Accent700 { get; } = Color.FromHex("#000000");
        public static Color Primary50Foreground { get; } = Color.FromHex("#000000");
        public static Color Primary100Foreground { get; } = Color.FromHex("#000000");
        public static Color Primary200Foreground { get; } = Color.FromHex("#000000");
        public static Color Primary300Foreground { get; } = Color.FromHex("#000000");
        public static Color Primary400Foreground { get; } = Color.FromHex("#000000");
        public static Color Primary500Foreground { get; } = Color.FromHex("#000000");
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

    public class GreySet : IColorSet
    { 
        public Color Primary50 { get; } = Grey.Primary50;
        public Color Primary100 { get; } = Grey.Primary100;
        public Color Primary200 { get; } = Grey.Primary200;
        public Color Primary300 { get; } = Grey.Primary300;
        public Color Primary400 { get; } = Grey.Primary400;
        public Color Primary500 { get; } = Grey.Primary500;
        public Color Primary600 { get; } = Grey.Primary600;
        public Color Primary700 { get; } = Grey.Primary700;
        public Color Primary800 { get; } = Grey.Primary800;
        public Color Primary900 { get; } = Grey.Primary900;
        public Color Accent100 { get; } = Grey.Accent100;
        public Color Accent200 { get; } = Grey.Accent200;
        public Color Accent400 { get; } = Grey.Accent400;
        public Color Accent700 { get; } = Grey.Accent700;
        public Color Primary50Foreground { get; } = Grey.Primary50Foreground;
        public Color Primary100Foreground { get; } = Grey.Primary100Foreground;
        public Color Primary200Foreground { get; } = Grey.Primary200Foreground;
        public Color Primary300Foreground { get; } = Grey.Primary300Foreground;
        public Color Primary400Foreground { get; } = Grey.Primary400Foreground;
        public Color Primary500Foreground { get; } = Grey.Primary500Foreground;
        public Color Primary600Foreground { get; } = Grey.Primary600Foreground;
        public Color Primary700Foreground { get; } = Grey.Primary700Foreground;
        public Color Primary800Foreground { get; } = Grey.Primary800Foreground;
        public Color Primary900Foreground { get; } = Grey.Primary900Foreground;
        public Color Accent100Foreground { get; } = Grey.Accent100Foreground;
        public Color Accent200Foreground { get; } = Grey.Accent200Foreground;
        public Color Accent400Foreground { get; } = Grey.Accent400Foreground;
        public Color Accent700Foreground { get; } = Grey.Accent700Foreground;
        public Color PrimaryHueLight { get; } = Grey.PrimaryHueLight;
        public Color PrimaryHueLightForeground { get; } = Grey.PrimaryHueLightForeground;
        public Color PrimaryHueMid { get; } = Grey.PrimaryHueMid;
        public Color PrimaryHueMidForeground { get; } = Grey.PrimaryHueMidForeground;
        public Color PrimaryHueDark { get; } = Grey.PrimaryHueDark;
        public Color PrimaryHueDarkForeground { get; } = Grey.PrimaryHueDarkForeground;
        public Color SecondaryAccent { get; } = Grey.SecondaryAccent;
        public Color SecondaryAccentForeground { get; } = Grey.SecondaryAccentForeground;
    }
}