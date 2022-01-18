# [H.XamlExtensions](https://github.com/HavenDV/H.XamlExtensions/) 

[![Language](https://img.shields.io/badge/language-C%23-blue.svg?style=flat-square)](https://github.com/HavenDV/H.XamlExtensions/search?l=C%23&o=desc&s=&type=Code) 
[![License](https://img.shields.io/github/license/HavenDV/H.XamlExtensions.svg?label=License&maxAge=86400)](LICENSE.md) 
[![Build Status](https://github.com/HavenDV/H.XamlExtensions/actions/workflows/dotnet.yml/badge.svg)](https://github.com/HavenDV/H.XamlExtensions/actions/workflows/dotnet.yml)

Shortest way to create rows/columns for Grid for WPF/UWP/Uno platforms

### NuGet

[![NuGet](https://img.shields.io/nuget/dt/H.XamlExtensions.Wpf.svg?style=flat-square&label=H.XamlExtensions.Wpf)](https://www.nuget.org/packages/H.XamlExtensions.Wpf/)
[![NuGet](https://img.shields.io/nuget/dt/H.XamlExtensions.Uno.svg?style=flat-square&label=H.XamlExtensions.Uno)](https://www.nuget.org/packages/H.XamlExtensions.Uno/)
[![NuGet](https://img.shields.io/nuget/dt/H.XamlExtensions.Uwp.svg?style=flat-square&label=H.XamlExtensions.Uwp)](https://www.nuget.org/packages/H.XamlExtensions.Uwp/)

```
Install-Package H.XamlExtensions.Wpf
Install-Package H.XamlExtensions.Uno
Install-Package H.XamlExtensions.Uwp
```

## Usage

### GridExtensions
```
// WPF
xmlns:e="clr-namespace:H.XamlExtensions;assembly=H.XamlExtensions.Wpf" 
// UWP/Uno
xmlns:e="using:H.XamlExtensions"
```
```xml
<!-- Auto,Auto,*,Auto,Auto -->
<Grid e:GridExtensions.ColumnsAndRows="A,A,*,A,A;A,A,*,A,A"/>
<!-- *[MinWidth: 300, MaxWidth: 400],* -->
<Grid e:GridExtensions.Rows="*[300-400],*"/>
<!-- *[MinWidth: 300],* -->
<Grid e:GridExtensions.Rows="*[300],*"/>
<!-- *[MaxWidth: 300],* -->
<Grid e:GridExtensions.Rows="*[0-300],*"/>
```

## Contacts
* [mail](mailto:havendv@gmail.com)