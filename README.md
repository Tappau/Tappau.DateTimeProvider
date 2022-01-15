# Tappau.DateTimeProvider
Simple library that provides an abstraction over static DateTime and DateTimeOffset classes.

Has a Microsoft.ServiceCollection.Extension to register either of the implementations as Singleton.

This allows us to not rely on static class, and enable simple mocking of DateTime utilities in our codebase.
