using UnityEngine;
using System.Collections.Generic;

public class BrewingStandManager : MonoBehaviour
{
	public static BrewingStandManager instance;

	public Queue<ScriptableObject>	drinkList = new Queue<ScriptableObject>();
	public Queue<ScriptableObject>	unlockedDrinks = new Queue<ScriptableObject>();
	
	void Awake()
	{
		if (instance == null)
			instance = this;
		else
			Destroy(gameObject);
	}

	public void GetBrews(GameObject panel)
	{
		
	}
}
