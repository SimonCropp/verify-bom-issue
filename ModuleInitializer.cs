using System.Runtime.CompilerServices;

namespace verify_bom_issue;

public static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Initialize()
    {
        VerifierSettings.UseUtf8NoBom();
    }
}
