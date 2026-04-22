// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class OpenXRHMD : ModuleRules
{
    public OpenXRHMD(ReadOnlyTargetRules Target) : base(Target)
    {
        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
                "CoreUObject",
                "Engine",
                "HeadMountedDisplay",
                "XRBase",
                "RenderCore",
                "Renderer",
                "Slate",
                "SlateCore",
                "AugmentedReality",
                "EngineSettings",
                "RHI",
                "BuildSettings"
            }
        );

        // === REQUIRED FOR UE 5.3.2-CSS ===
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        PrivatePCHHeaderFile = "Private/OpenXRHMD.h";
    }
}