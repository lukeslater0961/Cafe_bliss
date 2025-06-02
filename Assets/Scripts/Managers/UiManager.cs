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

	public void Toggle(UiPanel panel, bool toggleValue)
	{
		if ((int)panel <= panels.Count)
			Debug.Log($"toggling{toggleValue}");
	}
}
