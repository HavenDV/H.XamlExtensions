#nullable enable

namespace H.XamlExtensions;

#if HAS_AVALONIA
public class GridExtensions : AvaloniaObject
#else
public static class GridExtensions
#endif
{
#if HAS_AVALONIA
    static GridExtensions()
    {
        ColumnsAndRowsProperty.Changed.Subscribe(x => OnColumnsAndRowsChanged(x.Sender, x));
        ColumnsProperty.Changed.Subscribe(x => OnColumnsChanged(x.Sender, x));
        RowsProperty.Changed.Subscribe(x => OnRowsChanged(x.Sender, x));
    }
#endif

    #region ColumnsAndRows

#if HAS_AVALONIA
    public static readonly AttachedProperty<string?> ColumnsAndRowsProperty =
        AvaloniaProperty.RegisterAttached<GridExtensions, Grid, string?>(
            nameof(ColumnsAndRowsProperty).Replace("Property", string.Empty),
            string.Empty,
            false,
            BindingMode.OneTime);
#else
    public static readonly DependencyProperty ColumnsAndRowsProperty =
        DependencyProperty.RegisterAttached(
            nameof(ColumnsAndRowsProperty).Replace("Property", string.Empty),
            typeof(string),
            typeof(GridExtensions),
            new PropertyMetadata(string.Empty, OnColumnsAndRowsChanged));
#endif

#if HAS_WPF
    [AttachedPropertyBrowsableForType(typeof(Grid))]
#endif
    public static string? GetColumnsAndRows(DependencyObject element)
    {
        element = element ?? throw new ArgumentNullException(nameof(element));

        return (string?)element.GetValue(ColumnsAndRowsProperty);
    }

    public static void SetColumnsAndRows(DependencyObject element, string? value)
    {
        element = element ?? throw new ArgumentNullException(nameof(element));

        element.SetValue(ColumnsAndRowsProperty, value);
    }

    private static void OnColumnsAndRowsChanged(
        DependencyObject element,
#if HAS_AVALONIA
        AvaloniaPropertyChangedEventArgs<string?> args)
#else
        DependencyPropertyChangedEventArgs args)
#endif
    {
        if (element is not Grid grid)
        {
            throw new ArgumentException($"Element should be {nameof(Grid)}.");
        }

#if HAS_AVALONIA
        if (args.NewValue.GetValueOrDefault() is not string columnsAndRows)
#else
        if (args.NewValue is not string columnsAndRows)
#endif
        {
            throw new ArgumentException($"Value should be {nameof(String)}.");
        }

        grid.SetColumnsAndRows(columnsAndRows);
    }

    #endregion

    #region Columns

#if HAS_AVALONIA
    public static readonly AttachedProperty<string?> ColumnsProperty =
        AvaloniaProperty.RegisterAttached<GridExtensions, Grid, string?>(
            nameof(ColumnsProperty).Replace("Property", string.Empty),
            string.Empty,
            false,
            BindingMode.OneTime);
#else
    public static readonly DependencyProperty ColumnsProperty =
        DependencyProperty.RegisterAttached(
            nameof(ColumnsProperty).Replace("Property", string.Empty),
            typeof(string),
            typeof(GridExtensions),
            new PropertyMetadata(string.Empty, OnColumnsChanged));
#endif

#if HAS_WPF
    [AttachedPropertyBrowsableForType(typeof(Grid))]
#endif
    public static string? GetColumns(DependencyObject element)
    {
        element = element ?? throw new ArgumentNullException(nameof(element));

        return (string?)element.GetValue(ColumnsProperty);
    }

    public static void SetColumns(DependencyObject element, string? value)
    {
        element = element ?? throw new ArgumentNullException(nameof(element));

        element.SetValue(ColumnsProperty, value);
    }

    private static void OnColumnsChanged(
        DependencyObject element,
#if HAS_AVALONIA
        AvaloniaPropertyChangedEventArgs<string?> args)
#else
        DependencyPropertyChangedEventArgs args)
#endif
    {
        if (element is not Grid)
        {
            throw new ArgumentException($"Element should be {nameof(Grid)}.");
        }

#if HAS_AVALONIA
        if (args.NewValue.GetValueOrDefault() is not string columns)
#else
        if (args.NewValue is not string columns)
#endif
        {
            throw new ArgumentException($"Value should be {nameof(String)}.");
        }

#if HAS_WPF
        element.SetCurrentValue(ColumnsAndRowsProperty, $"{columns};*");
#else
        element.SetValue(ColumnsAndRowsProperty, $"{columns};*");
#endif
    }

    #endregion

    #region Rows

#if HAS_AVALONIA
    public static readonly AttachedProperty<string?> RowsProperty =
        AvaloniaProperty.RegisterAttached<GridExtensions, Grid, string?>(
            nameof(RowsProperty).Replace("Property", string.Empty),
            string.Empty,
            false,
            BindingMode.OneTime);
#else
    public static readonly DependencyProperty RowsProperty =
        DependencyProperty.RegisterAttached(
            nameof(RowsProperty).Replace("Property", string.Empty),
            typeof(string),
            typeof(GridExtensions),
            new PropertyMetadata(string.Empty, OnRowsChanged));
#endif

#if HAS_WPF
    [AttachedPropertyBrowsableForType(typeof(Grid))]
#endif
    public static string? GetRows(DependencyObject element)
    {
        element = element ?? throw new ArgumentNullException(nameof(element));

        return (string?)element.GetValue(RowsProperty);
    }

    public static void SetRows(DependencyObject element, string? value)
    {
        element = element ?? throw new ArgumentNullException(nameof(element));

        element.SetValue(RowsProperty, value);
    }

    private static void OnRowsChanged(
        DependencyObject element,
#if HAS_AVALONIA
        AvaloniaPropertyChangedEventArgs<string?> args)
#else
        DependencyPropertyChangedEventArgs args)
#endif
    {
        if (element is not Grid)
        {
            throw new ArgumentException($"Element should be {nameof(Grid)}.");
        }

#if HAS_AVALONIA
        if (args.NewValue.GetValueOrDefault() is not string rows)
#else
        if (args.NewValue is not string rows)
#endif
        {
            throw new ArgumentException($"Value should be {nameof(String)}.");
        }

#if HAS_WPF
        element.SetCurrentValue(ColumnsAndRowsProperty, $"*;{rows}");
#else
        element.SetValue(ColumnsAndRowsProperty, $"*;{rows}");
#endif
    }

#endregion
}