using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using TMPro;

public enum UiPanel
{
	MainMenu,
	Options,
	Game,
	Quests,
	Shop,
	Summary
}

public class UiManager : MonoBehaviour
{
	public static UiManager instance;
	public List<GameObject> panels;

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

    void Start()
    {
		GameEventManager.OnEndOfDay += UpdateSummaryUI;
    }

	public void Toggle(UiPanel panel)
	{
		if ((int)panel <= panels.Count)
		{
			Debug.Log($"toggling panel = {panel}");
			panels[(int)panel].SetActive(true);
		}
	}

	public void ToggleOff(UiPanel panel)
	{
		if ((int)panel < panels.Count)
			panels[(int)panel].SetActive(false);
	}

	public void ToggleQuests(bool value)
	{
		MenuStateManager.instance.SwitchState(MenuStateManager.questState);
	}

	public void ToggleShop(bool value)
	{
		MenuStateManager.instance.SwitchState(MenuStateManager.shopState);
	}

	public 	void UpdateSummaryUI()
	{
		TextMeshProUGUI[] textElements;
		textElements = panels[(int)UiPanel.Summary].GetComponentsInChildren<TextMeshProUGUI>();
		Debug.Log($"textElements[1]: {textElements[1]}, Component: {textElements[1].GetType().Name}");
		textElements[1].text = $"Coins collected : {CurrencyManager.instance.coins}";
		textElements[2].text = $"Satisfaction Multiplier : x{CurrencyManager.instance.GetSatisfactionMultiplier()}";
		textElements[3].text = $"Total : {CurrencyManager.instance.ApplyMultiplier()}";
	}
}
