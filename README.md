# Extensions for Xamarin.iOS
![GitHub](https://img.shields.io/github/license/SByteDev/Net.Xamarin.iOS.Extensions.svg)
![Nuget](https://img.shields.io/nuget/v/SByteDev.Xamarin.iOS.Extensions.svg)
[![Build Status](https://img.shields.io/bitrise/40bc65fa6cbbbe67/develop?label=development&token=nb5ptlUig_ZdZ7u0l6BmIQ&branch)](https://app.bitrise.io/app/40bc65fa6cbbbe67)
[![Build Status](https://img.shields.io/bitrise/40bc65fa6cbbbe67/master?label=production&token=nb5ptlUig_ZdZ7u0l6BmIQ&branch)](https://app.bitrise.io/app/40bc65fa6cbbbe67)
[![CodeFactor](https://www.codefactor.io/repository/github/sbytedev/net.xamarin.ios.extensions/badge)](https://www.codefactor.io/repository/github/sbytedev/net.xamarin.ios.extensions)

Extensions is a .Net Standard library with common iOS extensions and helpers written for Xamarin.

## Installation

Use [NuGet](https://www.nuget.org) package manager to install this library.

```bash
Install-Package SByteDev.Xamarin.iOS.Extensions
```

## Usage
```cs
using SByteDev.Xamarin.iOS.Extensions;
```

### NSObject Extensions
To perform an `Action` on the main UI thread with current thread check:

```cs
@object.InvokeOnMainThreadIfNeeded(action); 
```

### UIApplication Extensions
To get the topmost presented `UIViewController`:

```cs
var topViewController = UIApplication.SharedApplication.GetTopViewController(); 
```

### UIColor Extensions
To convert a `UIColor` into a hexadecimal color:

```cs
var hex = UIColor.Red.ToHexColor();
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update the tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
