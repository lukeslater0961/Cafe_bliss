using UnityEngine;
using System.Collections.Generic;

public class ShopManager : MonoBehaviour
{
	public static ShopManager instance;

	void Awake()
	{
		if (instance == null)
			instance = this;
		else
			Destroy(this.gameObject);
	}

	public void BuyItem(GameObject item, int price)
	{
		ItemScript script = item.GetComponent<ItemScript>();
		if (item && CurrencyManager.instance.coins >= price)
		{
			//buy item
			Debug.Log($"Bought item {item.name}");
			ItemScript.itemInfo.isBought = !ItemScript.itemInfo.isBought;
		}
		else//Make a colour animation in UI or a movement animation
			Debug.Log($"Not enough currency {CurrencyManager.instance.coins}");
	}
}
