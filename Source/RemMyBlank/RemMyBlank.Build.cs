// Copyright Epic Games, Inc. All Rights Reserved.


namespace UnrealBuildTool.Rules
{
	public class RemMyBlank : ModuleRules
	{
		public RemMyBlank(ReadOnlyTargetRules target) : base(target)
		{
			PCHUsage					= PCHUsageMode.UseExplicitOrSharedPCHs;
			bLegacyPublicIncludePaths	= false;
			ShadowVariableWarningLevel	= WarningLevel.Error;
			CppStandard 				= CppStandardVersion.Cpp20;

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
					
					/*"RemCommon",*/
					
					// ... add private dependencies that you statically link with here ...
				}
			);
		}
	}
}
