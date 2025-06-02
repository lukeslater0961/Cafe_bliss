using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStateManager : MonoBehaviour
{
	MenuBaseState	 currentState;

	public static	MenuStateManager instance;

	public		 OptionsState	optionsState = new OptionsState();
	public		 QuestState		questState = new QuestState();
	public		 ShopState		shopState = new ShopState();
	public		 GameState		gameState = new GameState();

	void Awake()
	{
		if (instance == null)
			instance = this;
		else
			Destroy(gameObject);
	}

    void Start()
    {
		DontDestroyOnLoad(this.gameObject);
        currentState = gameState;
		currentState.EnterState(this);
    }

	public void SwitchState(MenuBaseState state)
	{
		currentState = state;
		currentState.EnterState(this);
	}
}
