// Copyright RemRemRemRe, All Rights Reserved.

namespace UnrealBuildTool.Rules
{
	public class RemMyBlank : ModuleRules
	{
		public RemMyBlank(ReadOnlyTargetRules target) : base(target)
		{
			PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
			ShadowVariableWarningLevel = WarningLevel.Error;
			IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
			DefaultBuildSettings = BuildSettingsVersion.Latest;
			CppStandard = CppStandardVersion.Cpp20;

			bEnableNonInlinedGenCppWarnings = true;
			bUseUnity = false;

			PrivateDependencyModuleNames.AddRange(
				new[]
				{
					"Core",
					"CoreUObject",
					"Engine",
					
					/*"RemCommon",*/
				}
			);
		}
	}
}
