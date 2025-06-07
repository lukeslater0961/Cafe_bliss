using UnityEngine;

public class Test : MonoBehaviour
{
	public GameObject prefab;
	Transform parent;

	//can be used to instantiate things into a Ui layout group
	void OnEnable()
	{
		parent = gameObject.transform;
		Instantiate(prefab, parent);
	}
}
