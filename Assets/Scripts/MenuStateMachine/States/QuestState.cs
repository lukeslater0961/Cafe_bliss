using UnityEngine;

public class QuestState : MenuBaseState
{
	public override void EnterState(MenuStateManager menu)
	{
		Debug.Log($"entered {this.GetType().Name}");
	}
}
