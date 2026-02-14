namespace Jig.Shell;

[Flags]
public enum ShellLoggingOptions
{
    None = 0,
    StandardOutput = 1 << 0,
    StandardError = 1 << 1
}