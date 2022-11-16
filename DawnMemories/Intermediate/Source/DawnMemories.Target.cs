using UnrealBuildTool;

public class DawnMemoriesTarget : TargetRules
{
	public DawnMemoriesTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("DawnMemories");
	}
}
