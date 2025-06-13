using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class QuestsManager : MonoBehaviour
{
	public static QuestsManager instance;

	[SerializeField]	List<Quest>	questsList;
	[SerializeField]	Quest		currentQuest;

	private QuestGoal				activeGoal;

	[SerializeField] GameObject		questSlot;

	GameObject instantiatedQuestSlot;
	QuestSlotUI slotUi;

	void Awake()
	{
		if (instance == null)
		{
			instance = this;
			DontDestroyOnLoad(this.gameObject);
		}
		else
			Destroy(gameObject);
	}

	public void AddQuest()
	{
		int questIndex = Random.Range(0, questsList.Count);	

		Debug.Log($"fetching quest {questIndex}");
		currentQuest = questsList[questIndex];
		activeGoal = Instantiate(currentQuest.questGoal);
		activeGoal.Initialise(currentQuest.amount);

		InitialiseQuestSlot();
		UiManager.instance.ToggleQuests(true);
	}

	public void RemoveQuest()
	{
		currentQuest = null;
		activeGoal = null;
	}

	public void UpdateQuest()
	{
		activeGoal.currentAmount++;
		slotUi.SetQuestInfo(currentQuest.questName, currentQuest.description, activeGoal.currentAmount.ToString());
		if (activeGoal.CheckCompletion())
			RemoveQuest();
	}

	void InitialiseQuestSlot()
	{
		Transform parent = UiManager.instance.panels[(int)UiPanel.Quests].transform;
		instantiatedQuestSlot = Instantiate(questSlot, parent);
		slotUi = instantiatedQuestSlot.GetComponent<QuestSlotUI>();

		string title = currentQuest.questName;
		string description = currentQuest.description;
		string progress = activeGoal.currentAmount.ToString();
		slotUi.SetQuestInfo(title , description, progress);
	}
}
