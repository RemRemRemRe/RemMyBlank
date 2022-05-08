// Copyright Epic Games, Inc. All Rights Reserved.

namespace UnrealBuildTool.Rules
{
	public class MyBlank : ModuleRules
	{
		public MyBlank(ReadOnlyTargetRules target) : base(target)
		{
			PCHUsage					= PCHUsageMode.UseExplicitOrSharedPCHs;
			bLegacyPublicIncludePaths	= false;
			ShadowVariableWarningLevel	= WarningLevel.Error;

			PrivateDependencyModuleNames.AddRange(
				new[]
				{
					"Core",
					/*"CoreUObject",
					"Engine",*/
					
					/*"Slate",
					"SlateCore",
					"UnrealEd",
					"PropertyEditor",
					"EditorStyle",
					"InputCore",*/
					
					/*"UMG",*/
					
					/*"Common",*/
					
					// ... add private dependencies that you statically link with here ...
				}
			);
		}
	}
}
