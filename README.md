# semantic-logging-core

Core semantic/structured logging for .NET

## Reason This Project Exists
As of Q4 '16, Microsoft seems to have abandoned Semantic Logging. This is a problem, particularly as 
Azure storage libraries are updated and become incompatible with Semantic Logging.

The reason for this project is to create a living, maintained set of sinks that can be used without fear 
of Azure storage library updates breaking software.

## What is Semantic Logging?

Semantic Logging (formerly know at the Semantic Logging Application Block or SLAB) is designed by the
[patterns & practices](http://aka.ms/mspnp) team to help .NET developers move from the unstructured
logging approach towards the strongly-typed (semantic) logging approach, making it easier to consume
logging information, especially when there is a large volume of log data to be analyzed. When used
out-of-process, Semantic Logging uses [_Event Tracing for Windows (ETW)_][ETW], a fast, lightweight, strongly
typed, extensible logging system that is built into the Windows operating system.

Semantic Logging enables you to use the [`EventSource`][EventSource] class and semantic log messages in your
applications without moving away from the log formats you are familiar with (such as database, text
file, Azure table storage). Also, you do not need to commit to how you consume events when developing
business logic; you have a unified application-specific API for logging and then you can decide later
whether you want those events to go to ETW or alternative destinations.

## How do I use Semantic Logging?

Official releases are available via NuGet.
You can also head to [msdn.com](https://msdn.microsoft.com/en-us/library/dn774980.aspx) for additional
information, documentation, videos, and hands-on labs.


