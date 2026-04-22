// Copyright Epic Games, Inc. All Rights Reserved.

using System.IO;
using UnrealBuildTool;

public class OpenXRAR : ModuleRules
{
    public OpenXRAR(ReadOnlyTargetRules Target) : base(Target)
    {
        var EngineDir = Path.GetFullPath(Target.RelativeEnginePath);
        PrivateIncludePaths.Add(Path.Combine(GetModuleDirectory("OpenXRHMD"), "Private"));

        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
                "Engine",
                "MRMesh"
            }
        );

        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "CoreUObject",
                "ApplicationCore",
                "HeadMountedDisplay",
                "AugmentedReality",
                "RenderCore",
                "RHI",
                "Projects",
                "OpenXRHMD",
                "XRBase",
            }
        );

        if (Target.bBuildEditor == true)
        {
            PrivateDependencyModuleNames.Add("UnrealEd");
        }

        PublicIncludePathModuleNames.Add("OpenXR");

        // === REQUIRED FOR UE 5.3.2-CSS ===
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        PrivatePCHHeaderFile = "Private/OpenXRAR.h";
    }
}