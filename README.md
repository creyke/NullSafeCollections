# NullSafeCollections
Iterate over C# collections without having to check for whether they are null

# Usage

## Installing
Install the [NuGet package](https://www.nuget.org/packages/NullSafeCollections) with a package manager.

## Example usage
```csharp
using System;

int[]? foo = null;

foreach (var item in NullSafe.Enumerable(foo))
{
    Console.WriteLine(item);
}
```

# FAQ

## Q. Is this production quality and ready to use in life-critical systems?
A. Yes.

## Q. What is the compatibility level?
A. It targets .NET standard 2.0.

## Q. Does it allocate a new empty collection each time?
A. No. Under the hood it uses Array.Empty<T>() which only creates one instance per type.

## Q. Can it do different collection types?
A. Yes. So far there is...
```csharp
NullSafe.Array()
NullSafe.Collection()
NullSafe.Enumerable()
NullSafe.List()
```
...feel free to PR more.
