using UnityEngine;

[CreateAssetMenu(fileName = "New Object", menuName = "Shop/Item")]
public class Item : ScriptableObject
{
	public Sprite	image;
	public string	nameTag;
	public int		price;
	public bool		isBought;
}
