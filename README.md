# Tappau.DateTimeProvider
[![CI](https://github.com/Tappau/Tappau.DateTimeProvider/actions/workflows/main.yml/badge.svg)](https://github.com/Tappau/Tappau.DateTimeProvider/actions/workflows/main.yml)


Simple library that provides an abstraction over static DateTime and DateTimeOffset classes.

# Install via Nuget

```
Install-Package Tappau.DateTimeProvider -Version 1.0.0
```


Has a Microsoft.ServiceCollection.Extension to register either of the implementations as Singleton.

This allows us to not rely on static class, and enable simple mocking of DateTime utilities in our codebase.
