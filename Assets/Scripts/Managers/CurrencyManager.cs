using UnityEngine;

public enum satisfactionLevel{
	VerySatisfied,
	Satisfied,
	UnSatisfied
}

public class CurrencyManager : MonoBehaviour
{
	public static CurrencyManager instance;

	int[]	satisfactionCounts = new int[3];
	public int		coins;

	void Awake()
	{
		if (instance == null)
			instance = this;
		else
			Destroy(this.gameObject);
	}

	void Start()
	{
		coins = 0;//set to value from save or 0f
	}

	public int	ApplyMultiplier()
	{
		float multiplier = GetSatisfactionMultiplier();
		coins = (int)(coins * (1 + multiplier));
		return coins;
	}
	
	float GetSatisfactionMultiplier()
	{
		float multiplier = 0f;
		multiplier += satisfactionCounts[(int)satisfactionLevel.VerySatisfied] * 0.08f;
		multiplier += satisfactionCounts[(int)satisfactionLevel.Satisfied] * 0.06f;
		multiplier += satisfactionCounts[(int)satisfactionLevel.UnSatisfied] * -0.025f;
		return Mathf.Clamp(multiplier, -0.2f, 1f);
	}

	public void IncrementSatisfaction(satisfactionLevel level)
	{
		switch ((int)level)
		{
			case 0:
				satisfactionCounts[(int)satisfactionLevel.VerySatisfied]++;
				break;
			case 1:
				satisfactionCounts[(int)satisfactionLevel.Satisfied]++;
				break;
			case 2:
				satisfactionCounts[(int)satisfactionLevel.UnSatisfied]++;
				break;
			default:
				break;
		}
	}
}
