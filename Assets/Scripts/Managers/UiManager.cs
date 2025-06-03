using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public enum UiPanel
{
	MainMenu,
	Options,
	Shop,
	Quests
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
		Debug.Log(panel);
		if ((int)panel <= panels.Count)
		{
			Debug.Log($"toggling panel = {panel}");
			for (int i = 0; i < panels.Count; i++)
			{
				bool shouldBeActive = (i == (int)panel);
				panels[i].SetActive(shouldBeActive);
			}
		}
	}
}
