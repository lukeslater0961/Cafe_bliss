using UnityEngine;

public class SettingsManager : MonoBehaviour
{
	public static SettingsManager instance;

	void Awake()
	{
		if (instance == null)
		{
			instance = this;
			DontDestroyOnLoad(this.gameObject);
		}
		else 
			Destroy(this.gameObject);
	}

	public void LoadSettings()
	{
		Debug.Log("loading settings");
	}

	public	void SaveSettings()
	{
		Debug.Log("Saving settings");
	}
}
