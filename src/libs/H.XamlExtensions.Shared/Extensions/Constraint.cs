using System.Globalization;

#nullable enable

namespace H.XamlExtensions;

public class Constraint
{
    public GridLength Value { get; set; }
    public double MinValue { get; set; }
    public double MaxValue { get; set; } = double.PositiveInfinity;

    public static Constraint Parse(string text)
    {
        text = text ?? throw new ArgumentNullException(nameof(text));

        var valueString = text.Contains('[')
            ? text.Substring(0, text.IndexOf('['))
            : text;
        var minMaxString = text.Contains('[')
            ? text.Substring(text.IndexOf('[') + 1).TrimEnd(']')
            : string.Empty;
        var minString = minMaxString.Contains('-')
            ? minMaxString.Substring(0, minMaxString.IndexOf('-'))
            : minMaxString;
        var maxString = minMaxString.Contains('-')
            ? minMaxString.Substring(minMaxString.IndexOf('-') + 1)
            : string.Empty;

        var value = GridLengthConverter.ConvertFromInvariantString(valueString);
        var minValue = double.TryParse(
            minString,
            NumberStyles.Any,
            CultureInfo.InvariantCulture,
            out var minValueResult)
            ? minValueResult
            : 0.0;
        var maxValue = double.TryParse(
            maxString,
            NumberStyles.Any,
            CultureInfo.InvariantCulture,
            out var maxValueResult)
            ? maxValueResult
            : double.PositiveInfinity;

        return new Constraint
        {
            Value = value,
            MinValue = minValue,
            MaxValue = maxValue,
        };
    }
}