using UnrealBuildTool;

public class Eduhackathon2Target : TargetRules
{
	public Eduhackathon2Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Eduhackathon2");
	}
}
