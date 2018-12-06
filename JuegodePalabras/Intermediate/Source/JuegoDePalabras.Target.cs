using UnrealBuildTool;

public class JuegoDePalabrasTarget : TargetRules
{
	public JuegoDePalabrasTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("JuegoDePalabras");
	}
}
