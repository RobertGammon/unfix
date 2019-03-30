# unfix
Adapter classes for c# static types.

## IDateTimeAdapter
An interface that mirrors the static methods on `System.DateTime`. The interface is implemented by `Implementations.DateTimeAdapter`, which simply
delegates to `System.DateTime`.

This allows you to make classes that need DateTime functionality depend on the IDateTimeAdapter interface, which can be mocked out for testing,
and supplied with the implementation in production.
