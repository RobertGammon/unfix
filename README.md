# unfix
Adapter classes for c# static types.

## IDateTimeAdapter
An interface that mirrors the static methods on `System.DateTime`. The interface is implemented by `Implementations.DateTimeAdapter`, which simply
delegates to `System.DateTime`.

When you have a class that requires DateTime functionality, this dependency can be made explicit by using the IDateTimeAdapter interface, which
can be mocked out for testing, and supplied with the real implementation in production.
