# xBuild.Notifications

## Overview

Provides lifetime hooks that generate notifications when targets fail and builds complete.

## Usage

Call `.AddNotifications()` when constructing the build to add the required services.

## Requirements

Uses xBuild.Shell which is added to the build automatically.

Backend mechanisms:

| OS      | Mechanism   |
|---------|-------------|
| Ubuntu  | notify-send |
| MacOS   | osascript   |
| Windows | TODO        |
