using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public enum UiPanel
{
	Options,
	Shop,
	Quests
}

public class UiManager : MonoBehaviour
{
	public static UiManager instance;
	public List<Canvas> panels;

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
			for (int index = 0; index < panels.Count; index++)
			{
				if (index != (int)panel)
					panels[index].enabled = false;
				else
					panels[index].enabled = true;
			}
		}
	}
}
