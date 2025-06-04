using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsState : MenuBaseState
{
    public override void EnterState(MenuStateManager menu)
	{
		Debug.Log($"entered {this.GetType().Name}");
		UiManager.instance.Toggle(UiPanel.Options);
	}

	public override void HandleEscape(MenuStateManager menu, Scene currentScene)
	{
		UiManager.instance.ToggleOff(UiPanel.Options);
		if (currentScene.name == "MainMenu")
			menu.SwitchState(MenuStateManager.mainMenuState);
		else
			menu.SwitchState(MenuStateManager.gameState);
	}

}
