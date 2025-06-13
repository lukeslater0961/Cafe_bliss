using UnityEngine;

[CreateAssetMenu(fileName = "New Quest", menuName = "Quest System/Quest")]
public class Quest : ScriptableObject
{
    public string	questName;
	public string	description;
	public int		amount;
	public QuestGoal	questGoal;
}
