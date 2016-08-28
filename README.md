# Material Design Colors for Xamarin Forms

Material design colors which you can use statically from Xamarin Forms.

# Dependencies

- Xamarin Forms v2.3.1.114.

# Usage

Initialize your primary and accent colors from App.xaml.cs.

```c#
MaterialColors.Initialize(MaterialColors.Blue, MaterialColors.LightBlue);
```

Bind to them from your views.

You can reference colors based on the primary and accent colors you've chosen, or reference specific colors directly.

```xaml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:App1"
             xmlns:mat="clr-namespace:MaterialDesignColors;assembly=MaterialDesignColors"
             x:Class="App1.MainPage">

  <StackLayout>

    <Label Text="Primary Light (200)" FontSize="24" HeightRequest="100"
           VerticalTextAlignment="Center" HorizontalTextAlignment="Center"
           BackgroundColor="{x:Static mat:MaterialColors.PrimaryHueLight}"
           TextColor="{x:Static mat:MaterialColors.PrimaryHueLightForeground}" />

    <Label Text="Primary Mid (500)" FontSize="24" HeightRequest="100"
           VerticalTextAlignment="Center" HorizontalTextAlignment="Center"
           BackgroundColor="{x:Static mat:MaterialColors.PrimaryHueMid}"
           TextColor="{x:Static mat:MaterialColors.PrimaryHueMidForeground}" />

    <Label Text="Primary Dark (700)" FontSize="24" HeightRequest="100"
           VerticalTextAlignment="Center" HorizontalTextAlignment="Center"
           BackgroundColor="{x:Static mat:MaterialColors.PrimaryHueDark}"
           TextColor="{x:Static mat:MaterialColors.PrimaryHueDarkForeground}" />

    <Label Text="Secondary Accent (A700)" FontSize="24" HeightRequest="100"
           VerticalTextAlignment="Center" HorizontalTextAlignment="Center"
           BackgroundColor="{x:Static mat:MaterialColors.SecondaryAccent}"
           TextColor="{x:Static mat:MaterialColors.SecondaryAccentForeground}" />

    <Label Text="Grey Mid (500)" FontSize="24" HeightRequest="100"
           VerticalTextAlignment="Center" HorizontalTextAlignment="Center"
           BackgroundColor="{x:Static mat:Grey.PrimaryHueMid}"
           TextColor="{x:Static mat:Grey.PrimaryHueMidForeground}" />

    <Label Text="Deep Orange 500 (500)" FontSize="24" HeightRequest="100"
           VerticalTextAlignment="Center" HorizontalTextAlignment="Center"
           BackgroundColor="{x:Static mat:DeepOrange.Primary500}"
           TextColor="{x:Static mat:DeepOrange.Primary500Foreground}" />

  </StackLayout>

</ContentPage>
```

The above page would render as follows (in this case, on UWP).

![screenshot](https://i.imgur.com/Z8ncoSX.png)

You can also reference the colors straight from C#, which could come in handy if you're building up a higher level set of colors.

```c#
public static class MyTheme
{
    public static Color TabBarBackground => MaterialColors.PrimaryHueMid;
    public static Color TabBarForeground => MaterialColors.PrimaryHueMidForeground;

    public static Color LogoForeground => MaterialColors.Purple.Primary900;
    public static Color DescriptionForeground => MaterialColors.Purple.Primary700;
}
```

If you'd like a visual reference, there are several resources available online.

- https://www.materialui.co/colors
- https://material.google.com/style/color.html

# License

The MIT License (MIT)
Copyright (c) 2016 Joe Brock

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
