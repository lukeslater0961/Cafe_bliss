using UnityEngine;

public class ShopState : MenuBaseState
{
	public override void EnterState(MenuStateManager menu)
	{
		Debug.Log($"entered {this.GetType().Name}");
		UiManager.instance.Toggle(UiPanel.Shop);
	}
}
