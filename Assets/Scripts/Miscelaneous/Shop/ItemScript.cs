using UnityEngine;

public class ItemScript : MonoBehaviour
{
	[SerializeField]	Item itemInfo;

	public void OnClick(bool value)
	{
		ShopManager.instance.BuyItem(this.gameObject, itemInfo.price);
	}
}
