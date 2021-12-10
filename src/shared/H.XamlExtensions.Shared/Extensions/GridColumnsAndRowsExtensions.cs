﻿#nullable enable

namespace H.XamlExtensions;

public static class GridColumnsAndRowsExtensions
{
    #region Methods

    public static void SetColumnsAndRows(
        this Grid grid,
        string columnsAndRows)
    {
        grid = grid ?? throw new ArgumentNullException(nameof(grid));
        columnsAndRows = columnsAndRows ?? throw new ArgumentNullException(nameof(columnsAndRows));

        grid.ColumnDefinitions.Clear();
        grid.RowDefinitions.Clear();

        if (string.IsNullOrWhiteSpace(columnsAndRows))
        {
            return;
        }

        var values = columnsAndRows.Split(';');
        foreach (var constraint in (values.ElementAtOrDefault(0) ?? "*")
            .Split(',')
            .Select(Constraint.Parse))
        {
            grid.ColumnDefinitions.Add(new ColumnDefinition
            {
                Width = constraint.Value,
                MinWidth = constraint.MinValue,
                MaxWidth = constraint.MaxValue,
            });
        }

        foreach (var constraint in (values.ElementAtOrDefault(1) ?? "*")
            .Split(',')
            .Select(Constraint.Parse))
        {
            grid.RowDefinitions.Add(new RowDefinition
            {
                Height = constraint.Value,
                MinHeight = constraint.MinValue,
                MaxHeight = constraint.MaxValue,
            });
        }
    }

    #endregion
}