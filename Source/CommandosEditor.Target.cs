// Copyright Bibbit New Fields. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class CommandosEditorTarget : TargetRules
{
	public CommandosEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("Commandos");
	}
}
