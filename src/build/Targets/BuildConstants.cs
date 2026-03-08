using Microsoft.VisualStudio.SolutionPersistence.Model;
using Microsoft.VisualStudio.SolutionPersistence.Serializer;

namespace build.Targets;

public class BuildConstants
{
    public const string SolutionPath = "Jig.slnx";

    public static Task<SolutionModel> Solution
    {
        get
        {
            if (field is not null)
            {
                return field;
            }

            var filePath = Path.Combine(Directory.GetCurrentDirectory(), SolutionPath);
            return field ??= SolutionSerializers.GetSerializerByMoniker(filePath)!.OpenAsync(filePath, CancellationToken.None);
        }
    }
}