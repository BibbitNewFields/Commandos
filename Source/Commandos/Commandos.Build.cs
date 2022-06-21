// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Commandos : ModuleRules
{
	public Commandos(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "NavigationSystem", "AIModule", "Niagara" });
	}
}
