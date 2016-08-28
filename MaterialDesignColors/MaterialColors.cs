using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MaterialDesignColors
{
    public static class MaterialColors
    {
        public static Color PrimaryHueLight           => Primary.PrimaryHueLight;
        public static Color PrimaryHueLightForeground => Primary.PrimaryHueLightForeground;
        public static Color PrimaryHueMid             => Primary.PrimaryHueMid;
        public static Color PrimaryHueMidForeground   => Primary.PrimaryHueMidForeground;
        public static Color PrimaryHueDark            => Primary.PrimaryHueDark;
        public static Color PrimaryHueDarkForeground  => Primary.PrimaryHueDarkForeground;
        public static Color SecondaryAccent           => Accent.SecondaryAccent;
        public static Color SecondaryAccentForeground => Accent.SecondaryAccentForeground;

        public static IColorSet Primary { get; private set; }
        public static IColorSet Accent { get; private set; }

        public static AmberSet Amber           = new AmberSet();
        public static BlueSet Blue             = new BlueSet();
        public static BlueGreySet BlueGrey     = new BlueGreySet();
        public static BrownSet Brown           = new BrownSet();
        public static CyanSet Cyan             = new CyanSet();
        public static DeepOrangeSet DeepOrange = new DeepOrangeSet();
        public static DeepPurpleSet DeepPurple = new DeepPurpleSet();
        public static GreenSet Green           = new GreenSet();
        public static GreySet Grey             = new GreySet();
        public static IndigoSet Indigo         = new IndigoSet();
        public static LightBlueSet LightBlue   = new LightBlueSet();
        public static LightGreenSet LightGreen = new LightGreenSet();
        public static LimeSet Lime             = new LimeSet();
        public static OrangeSet Orange         = new OrangeSet();
        public static PinkSet Pink             = new PinkSet();
        public static PurpleSet Purple         = new PurpleSet();
        public static RedSet Red               = new RedSet();
        public static TealSet Teal             = new TealSet();
        public static YellowSet Yellow         = new YellowSet();

        public static void Initialize(IColorSet primary, IColorSet accent)
        {
            Primary = primary;
            Accent = accent;
        }
    }
}
