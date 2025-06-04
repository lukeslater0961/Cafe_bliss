using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;

	void Awake()
	{
		if (instance == null)
		{
			DontDestroyOnLoad(this.gameObject);
			instance = this;
		}
		else
			Destroy(gameObject);
	}

	public void QuitGame(bool value)
	{
		Application.Quit();
		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		#endif
	}
}
