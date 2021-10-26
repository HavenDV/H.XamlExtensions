# [GridExtensions](https://github.com/HavenDV/GridExtensions/) 

[![Language](https://img.shields.io/badge/language-C%23-blue.svg?style=flat-square)](https://github.com/HavenDV/GridExtensions/search?l=C%23&o=desc&s=&type=Code) 
[![License](https://img.shields.io/github/license/HavenDV/GridExtensions.svg?label=License&maxAge=86400)](LICENSE.md) 
[![Requirements](https://img.shields.io/badge/Requirements-.NET%20Standard%202.0-blue.svg)](https://github.com/dotnet/standard/blob/master/docs/versions/netstandard2.0.md)
[![Requirements](https://img.shields.io/badge/Requirements-.NET%20Framework%204.0-blue.svg)](https://github.com/microsoft/dotnet/blob/master/releases/net40/README.md)
[![Requirements](https://img.shields.io/badge/Requirements-.NET%20Framework%204.5-blue.svg)](https://github.com/microsoft/dotnet/blob/master/releases/net45/README.md)
[![Build Status](https://github.com/HavenDV/GridExtensions/actions/workflows/dotnet.yml/badge.svg)](https://github.com/HavenDV/GridExtensions/actions/workflows/dotnet.yml)

Shortest way to create rows/columns for Grid for WPF/UWP/Uno platforms

### NuGet

[![NuGet](https://img.shields.io/nuget/dt/GridExtensions.Wpf.svg?style=flat-square&label=GridExtensions.Wpf)](https://www.nuget.org/packages/GridExtensions.Wpf/)
[![NuGet](https://img.shields.io/nuget/dt/GridExtensions.Uno.svg?style=flat-square&label=GridExtensions.Uno)](https://www.nuget.org/packages/GridExtensions.Uno/)
[![NuGet](https://img.shields.io/nuget/dt/GridExtensions.Uwp.svg?style=flat-square&label=GridExtensions.Uwp)](https://www.nuget.org/packages/GridExtensions.Uwp/)

```
Install-Package GridExtensions.Wpf
Install-Package GridExtensions.Uno
Install-Package GridExtensions.Uwp
```

## Usage
```
// WPF
xmlns:e="clr-namespace:H.XamlExtensions;assembly=GridExtensions.Wpf" 
// UWP/Uno
xmlns:e="using:H.XamlExtensions"
```
```xml
<Grid e:GridExtensions.ColumnsAndRows="A,A,*,A,A;A,A,*,A,A"/>
```

## Contacts
* [mail](mailto:havendv@gmail.com)