using UnityEngine;

[CreateAssetMenu(fileName = "New Brew Goal", menuName = "Quest System/Goals/Brew Goal")]
public class BrewGoal : QuestGoal
{
	[SerializeField]	int brewingGoalAmount;
	
	public override void Initialise(int amount)
	{
		currentAmount = 0;
		brewingGoalAmount = amount;
		Debug.Log("initialising goal");
	}

	public override bool CheckCompletion()
	{
		return (currentAmount >= brewingGoalAmount);
	}
}
