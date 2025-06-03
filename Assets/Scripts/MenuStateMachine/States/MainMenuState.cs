using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuState : MenuBaseState
{
    public override void EnterState(MenuStateManager menu)
	{
		Debug.Log($"entered {this.GetType().Name}");
		UiManager.instance.Toggle(UiPanel.MainMenu);
	}

    public override void HandleEscape(MenuStateManager menu, Scene currentScene)
	{
		menu.SwitchState(MenuStateManager.optionsState);
	}
}
