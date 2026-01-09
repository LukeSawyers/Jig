# xBuild.Serilog

## Overview

Provides an `IBuildLogger` implementation that logs to Serilog. Relies on the built in build lifetime logging hooks
to log lifetime events.

Extends xBuild.Core to allow target executions to be wrapped with Polly resilience policies. 

## Configuration

Call `.AddSerilog(config => {})` when constructing the build to add the logger implementation. A default console
configuration is provided, but this can be overridden by supplying a lambda to the function call.