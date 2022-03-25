# [H.XamlExtensions](https://github.com/HavenDV/H.XamlExtensions/) 

Shortest way to create rows/columns for Grid for WPF/UWP/WinUI/Uno/Avalonia platforms

### NuGet

[![NuGet](https://img.shields.io/nuget/dt/H.XamlExtensions.Wpf.svg?style=flat-square&label=H.XamlExtensions.Wpf)](https://www.nuget.org/packages/H.XamlExtensions.Wpf/)
[![NuGet](https://img.shields.io/nuget/dt/H.XamlExtensions.Uno.svg?style=flat-square&label=H.XamlExtensions.Uno)](https://www.nuget.org/packages/H.XamlExtensions.Uno/)
[![NuGet](https://img.shields.io/nuget/dt/H.XamlExtensions.Uno.WinUI.svg?style=flat-square&label=H.XamlExtensions.Uno.WinUI)](https://www.nuget.org/packages/H.XamlExtensions.Uno.WinUI/)
[![NuGet](https://img.shields.io/nuget/dt/H.XamlExtensions.Uwp.svg?style=flat-square&label=H.XamlExtensions.Uwp)](https://www.nuget.org/packages/H.XamlExtensions.Uwp/)
[![NuGet](https://img.shields.io/nuget/dt/H.XamlExtensions.WinUI.svg?style=flat-square&label=H.XamlExtensions.WinUI)](https://www.nuget.org/packages/H.XamlExtensions.WinUI/)
[![NuGet](https://img.shields.io/nuget/dt/H.XamlExtensions.Avalonia.svg?style=flat-square&label=H.XamlExtensions.Avalonia)](https://www.nuget.org/packages/H.XamlExtensions.Avalonia/)

```
Install-Package H.XamlExtensions.Wpf
Install-Package H.XamlExtensions.Uno
Install-Package H.XamlExtensions.Uno.WinUI
Install-Package H.XamlExtensions.Uwp
Install-Package H.XamlExtensions.WinUI
Install-Package H.XamlExtensions.Avalonia
```

## Usage

### GridExtensions
```
// WPF
xmlns:e="clr-namespace:H.XamlExtensions;assembly=H.XamlExtensions.Wpf" 
// UWP/WinUI/Uno/Avalonia
xmlns:e="using:H.XamlExtensions"
```
```xml
<!-- Auto,50*,50*,Auto -->
<Grid e:GridExtensions.ColumnsAndRows="A,50*,50*,A;A,50*,50*,A"/>
<!-- *[MinWidth: 300, MaxWidth: 400],Auto -->
<Grid e:GridExtensions.Rows="*[300-400],Auto"/>
<!-- *[MinWidth: 300],* -->
<Grid e:GridExtensions.Rows="*[300],*"/>
<!-- *[MaxWidth: 300],* -->
<Grid e:GridExtensions.Rows="*[0-300],*"/>
```

## Contacts
* [mail](mailto:havendv@gmail.com)