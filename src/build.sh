#!/bin/bash
dotnet run --verbosity q --project build/build.csproj  -- "$@"
