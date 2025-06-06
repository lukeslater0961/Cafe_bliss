using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public enum UiPanel
{
	MainMenu,
	Options,
	Game,
	Shop,
	Quests,
	Brews
}

public class UiManager : MonoBehaviour
{
	public static UiManager instance;
	public List<GameObject> panels;

	void Awake()
	{
		if (instance == null)
			instance = this;
		else
			Destroy(gameObject);
	}

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

	public void Toggle(UiPanel panel)
	{
		if ((int)panel <= panels.Count)
		{
			Debug.Log($"toggling panel = {panel}");
			panels[(int)panel].SetActive(true);
			if (panel == UiPanel.Brews)
				BrewingStandManager.instance.GetBrews(panels[(int)panel]);
		}
	}

	public void ToggleOff(UiPanel panel)
	{
		if ((int)panel < panels.Count)
			panels[(int)panel].SetActive(false);
	}
}
