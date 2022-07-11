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
        Grid grid,
        string? oldValue,
        string? newValue)
    {
        grid.SetColumnsAndRows(newValue ?? string.Empty);
    }

    #endregion

    #region Columns

    static partial void OnColumnsChanged(
        Grid grid,
        string? oldValue,
        string? newValue)
    {
#if HAS_WPF
        grid.SetCurrentValue(ColumnsAndRowsProperty, $"{newValue};*");
#else
        grid.SetValue(ColumnsAndRowsProperty, $"{newValue};*");
#endif
    }

    #endregion

    #region Rows

    static partial void OnRowsChanged(
        Grid grid,
        string? oldValue,
        string? newValue)
    {
#if HAS_WPF
        grid.SetCurrentValue(ColumnsAndRowsProperty, $"*;{newValue}");
#else
        grid.SetValue(ColumnsAndRowsProperty, $"*;{newValue}");
#endif
    }
    
    #endregion
}