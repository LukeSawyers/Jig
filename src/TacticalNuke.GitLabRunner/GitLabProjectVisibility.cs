// Acquired originally from the NUKE Build project.
// Redistributed under the MIT License.
//
// Original Boilerplate:
// Copyright 2023 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using JetBrains.Annotations;

namespace TacticalNuke.GitLabRunner;

[PublicAPI]
public enum GitLabProjectVisibility
{
    Private,
    Internal,
    Public
}