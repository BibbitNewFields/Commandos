// Copyright Bibbit New Fields. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class CommandosTarget : TargetRules
{
	public CommandosTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("Commandos");
	}
}
