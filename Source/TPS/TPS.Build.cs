// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System;

public class TPS : ModuleRules
{
	public TPS(ReadOnlyTargetRules Target) : base(Target)
	{
		Console.WriteLine("TPS MODULE --------------------->");
        Console.WriteLine("TPS EDITOR TARGET --------------------->");
        Console.WriteLine("Unreal Version {0}.{1}.{2}", Target.Version.MajorVersion, Target.Version.MinorVersion, Target.Version.PatchVersion);
        Console.WriteLine("Platform {0}", Target.Platform);
        Console.WriteLine("Target type {0}", Target.Type);
        Console.WriteLine("Branch name {0}", Target.Version.BranchName);

        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	
    
        if(Target.Type == TargetType.Editor)
        {
            PublicDependencyModuleNames.Add("HeadMountedDisplay");
        }
    }
}
