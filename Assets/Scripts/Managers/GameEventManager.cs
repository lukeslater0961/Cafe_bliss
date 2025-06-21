using UnityEngine;
using System;

public class GameEventManager : MonoBehaviour
{
	public static GameEventManager instance;
	public static event Action OnEndOfDay;

	void Awake()
	{
		if (instance == null)
			instance = this;
		else
			Destroy(this.gameObject);
	}

	public void EndDay()
	{
		Debug.Log("End of day triggered");
		OnEndOfDay?.Invoke();
	}
}
