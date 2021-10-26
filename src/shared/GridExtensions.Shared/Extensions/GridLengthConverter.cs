using System.Globalization;
#if WPF
using System.Windows;
#else
using Windows.UI.Xaml;
#endif

#nullable enable

namespace H.XamlExtensions;

/// <summary>
/// https://referencesource.microsoft.com/#PresentationFramework/src/Framework/System/Windows/GridLengthConverter.cs
/// </summary>
public static class GridLengthConverter
{
    public static GridLength ConvertFromInvariantString(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return new GridLength(1, GridUnitType.Star);
        }

        if (text.ToUpperInvariant() is "AUTO" or "A")
        {
            return GridLength.Auto;
        }

        if (text.Contains('*'))
        {
            var value = text.Replace("*", string.Empty);

            return new GridLength(
                string.IsNullOrWhiteSpace(value)
                    ? 1
                    : Convert.ToDouble(value, CultureInfo.InvariantCulture),
                GridUnitType.Star);
        }

        return new GridLength(Convert.ToDouble(text, CultureInfo.InvariantCulture));
    }
}
