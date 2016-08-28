using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MaterialDesignColors
{
    public interface IColorSet
    {
        Color Primary50 { get; }
        Color Primary100 { get; }
        Color Primary200 { get; }
        Color Primary300 { get; }
        Color Primary400 { get; }
        Color Primary500 { get; }
        Color Primary600 { get; }
        Color Primary700 { get; }
        Color Primary800 { get; }
        Color Primary900 { get; }

        Color Accent100 { get; }
        Color Accent200 { get; }
        Color Accent400 { get; }
        Color Accent700 { get; }

        Color Primary50Foreground { get; }
        Color Primary100Foreground { get; }
        Color Primary200Foreground { get; }
        Color Primary300Foreground { get; }
        Color Primary400Foreground { get; }
        Color Primary500Foreground { get; }
        Color Primary600Foreground { get; }
        Color Primary700Foreground { get; }
        Color Primary800Foreground { get; }
        Color Primary900Foreground { get; }

        Color Accent100Foreground { get; }
        Color Accent200Foreground { get; }
        Color Accent400Foreground { get; }
        Color Accent700Foreground { get; }

        Color PrimaryHueLight { get; }
        Color PrimaryHueLightForeground { get; }
        Color PrimaryHueMid { get; }
        Color PrimaryHueMidForeground { get; }
        Color PrimaryHueDark { get; }
        Color PrimaryHueDarkForeground { get; }
        Color SecondaryAccent { get; }
        Color SecondaryAccentForeground { get; }
    }
}
