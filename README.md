# NullSafeCollections
Iterate over C# collections without having to check for whether they are null

# Usage

## Installing
Install the [NuGet package](https://www.nuget.org/packages/NullSafeCollections) with a package manager.

## Example usage
```csharp
foreach (var item in NullSafe.Enumerable(foo))
{
    Console.WriteLine(item);
}
```
