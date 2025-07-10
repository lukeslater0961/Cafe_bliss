using UnityEngine;
using System.Collections.Generic;

public class ShopManager : MonoBehaviour
{
	public static ShopManager instance;

	[SerializeField]	List<Quest>	itemList;
	[SerializeField]	GameObject	itemSlot;

	void Awake()
	{
		if (instance == null)
			instance = this;
		else
			Destroy(this.gameObject);
	}

	public void BuyItem(GameObject item, int price)
	{
		if (item && CurrencyManager.instance.coins >= price)
		{
			//buy item
		}
		else
			Debug.Log($"Not enough currency {CurrencyManager.instance.coins}");
	}
}
