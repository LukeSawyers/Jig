using _build.Targets;

namespace _build.NugetLicense;

public record LicenseValidationResult(
    string PackageId,
    string PackageVersion,
    string? PackageProjectUrl,
    string? License,
    string? LicenseUrl,
    string? Copyright,
    string? Authors,
    string? Description,
    string? Summary,
    LicenseInformationOrigin LicenseInformationOrigin,
    List<ValidationError>? ValidationErrors = null
);