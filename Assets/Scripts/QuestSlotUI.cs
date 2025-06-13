using UnityEngine;
using TMPro;

public class QuestSlotUI : MonoBehaviour
{
	public TextMeshProUGUI titleText;
	public TextMeshProUGUI descriptionText;
	public TextMeshProUGUI progressText;

	public void SetQuestInfo(string title, string description, string progress)
	{
		titleText.text = title;
		descriptionText.text = description;
		progressText.text = progress;
	}
}
