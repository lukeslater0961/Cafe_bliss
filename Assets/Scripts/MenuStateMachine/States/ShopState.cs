using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopState : MenuBaseState
{
	public override void EnterState(MenuStateManager menu)
	{
		Debug.Log($"entered {this.GetType().Name}");
		UiManager.instance.Toggle(UiPanel.Shop);
	}

	public override void HandleEscape(MenuStateManager menu, Scene currentScene)
	{
		UiManager.instance.ToggleOff(UiPanel.Shop);
		menu.SwitchState(MenuStateManager.gameState);
	}
}
