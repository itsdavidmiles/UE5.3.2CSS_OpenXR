using UnrealBuildTool;
using System.IO;

public class OpenXRHMD : ModuleRules
{
    public OpenXRHMD(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        PrivatePCHHeaderFile = "Private/OpenXRHMD.h";

        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Public"));
        PrivateIncludePaths.Add(Path.Combine(ModuleDirectory, "Private"));

        // Hardcoded path to your engine's OpenXR headers
        string OpenXRIncludePath = @"C:\Program Files\Unreal Engine - CSS\Engine\Source\ThirdParty\OpenXR\include";
        PublicSystemIncludePaths.Add(OpenXRIncludePath);

        PublicDependencyModuleNames.AddRange(new string[] {
            "Core", "CoreUObject", "Engine", "HeadMountedDisplay", "XRBase",
            "RHI", "RenderCore", "Renderer", "Slate", "SlateCore",
            "AugmentedReality", "InputCore"
        });

        PrivateDependencyModuleNames.Add("BuildSettings");

        if (Target.Platform == UnrealTargetPlatform.Win64)
        {
            PublicDependencyModuleNames.AddRange(new string[] { "D3D12RHI", "VulkanRHI" });
        }
    }
}