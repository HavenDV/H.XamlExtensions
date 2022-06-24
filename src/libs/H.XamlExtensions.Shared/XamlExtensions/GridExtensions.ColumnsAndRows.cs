#nullable enable

namespace H.XamlExtensions;

[AttachedDependencyProperty<string, Grid>("ColumnsAndRows", DefaultValue = "")]
[AttachedDependencyProperty<string, Grid>("Columns", DefaultValue = "")]
[AttachedDependencyProperty<string, Grid>("Rows", DefaultValue = "")]
#if HAS_AVALONIA
public partial class GridExtensions
#else
public static partial class GridExtensions
#endif
{
    #region ColumnsAndRows

    static partial void OnColumnsAndRowsChanged(
        Grid sender,
        string? oldValue,
        string? newValue)
    {
        sender.SetColumnsAndRows(newValue ?? string.Empty);
    }

    #endregion

    #region Columns

    static partial void OnColumnsChanged(
        Grid sender,
        string? oldValue,
        string? newValue)
    {
#if HAS_WPF
        sender.SetCurrentValue(ColumnsAndRowsProperty, $"{newValue};*");
#else
        sender.SetValue(ColumnsAndRowsProperty, $"{newValue};*");
#endif
    }

    #endregion

    #region Rows

    static partial void OnRowsChanged(
        Grid sender,
        string? oldValue,
        string? newValue)
    {
#if HAS_WPF
        sender.SetCurrentValue(ColumnsAndRowsProperty, $"*;{newValue}");
#else
        sender.SetValue(ColumnsAndRowsProperty, $"*;{newValue}");
#endif
    }
    
    #endregion
}