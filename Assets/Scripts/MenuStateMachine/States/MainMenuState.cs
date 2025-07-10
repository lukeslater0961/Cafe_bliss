using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuState : MenuBaseState
{
    public override void EnterState(MenuStateManager menu)
	{
		Debug.Log($"entered {this.GetType().Name}");
		UiManager.instance.Toggle(UiPanel.MainMenu);
		SettingsManager.instance.LoadSettings();
	}

    public override void HandleEscape(MenuStateManager menu, Scene currentScene)
	{
		UiManager.instance.ToggleOff(UiPanel.MainMenu);
		menu.SwitchState(MenuStateManager.optionsState);
	}
}
