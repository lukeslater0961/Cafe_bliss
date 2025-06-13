using UnityEngine;

public abstract class QuestGoal : ScriptableObject
{
	public int  currentAmount;
	public bool isCompleted;
	public abstract void Initialise(int amount);
	public abstract bool CheckCompletion();
}
