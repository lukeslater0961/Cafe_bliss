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

	void Initialise()
	{
		//get player info and add unlocked drinks to List
		GetBrews();
	}
	
	public void GetBrews()
	{
		//get the current brews and foreach unlocked, instantiate them into the UI
	}
}
