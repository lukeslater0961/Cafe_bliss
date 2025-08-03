using UnityEngine;

public class ItemScript : MonoBehaviour
{
	[SerializeField]	public static Item itemInfo;

	//On shop button click , call's the buy item function in the shop manager
	public void OnClick(bool value)
	{
		ShopManager.instance.BuyItem(this.gameObject, itemInfo.price);
	}
}
