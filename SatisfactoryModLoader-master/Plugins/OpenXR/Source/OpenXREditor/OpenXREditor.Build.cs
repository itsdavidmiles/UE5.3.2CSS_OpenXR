// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class OpenXREditor : ModuleRules
{
    public OpenXREditor(ReadOnlyTargetRules Target) : base(Target)
    {
        PrivateDependencyModuleNames.AddRange(
            new string[] {
                "Core",
                "CoreUObject",
                "EditorFramework",
                "UnrealEd",
                "OpenXRHMD",
                "OpenXRInput"
            }
        );

        // === REQUIRED FOR UE 5.3.2-CSS ===
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        PrivatePCHHeaderFile = "Private/OpenXREditorModule.h";   // Using a header that actually exists
    }
}