using UnityEngine;
using UnityEngine.SceneManagement;

public class DailySummaryState : MenuBaseState
{
    public override void EnterState(MenuStateManager menu)
	{
		Debug.Log($"entered {this.GetType().Name}");
		UiManager.instance.Toggle(UiPanel.Summary);
		GameManager.instance.TogglePause();
	}

    public override void HandleEscape(MenuStateManager menu, Scene currentScene)
	{
		menu.SwitchState(MenuStateManager.gameState);
	}
}
