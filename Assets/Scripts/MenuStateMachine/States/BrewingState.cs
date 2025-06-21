using UnityEngine;
using UnityEngine.SceneManagement;

public class BrewingState : MenuBaseState
{
	public override void EnterState(MenuStateManager menu)
	{
		Debug.Log($"entered {this.GetType().Name}");
		//UiManager.instance.Toggle(UiPanel.Brews);
	}

	public override void HandleEscape(MenuStateManager menu, Scene currentScene)
	{
		menu.SwitchState(MenuStateManager.gameState);
	}
}
