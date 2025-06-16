using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStateManager : MonoBehaviour
{
	MenuBaseState	 currentState;

	public static	MenuStateManager instance;

	public		static MainMenuState	mainMenuState = new MainMenuState();
	public		static GameState		gameState = new GameState();

	public		static OptionsState		optionsState = new OptionsState();
	public		static QuestState		questState = new QuestState();
	public		static ShopState		shopState = new ShopState();
	public		static BrewingState		brewingState = new BrewingState();
	public		static DailySummaryState	dailySummaryState = new DailySummaryState();
 
	void Awake()
	{
		if (instance == null)
		{
			instance = this;
			DontDestroyOnLoad(this.gameObject);
		}
		else
			Destroy(gameObject);
	}

    void Start()
    {
        currentState = mainMenuState;
		currentState.EnterState(this);
    }


	public void SwitchState(MenuBaseState state)
	{
		currentState = state;
		currentState.EnterState(this);
	}

	public void HandleEscapeInput(bool value)
	{
		Scene scene = SceneManager.GetActiveScene();
		currentState.HandleEscape(this, scene);
	}

	public void SwitchToGame(bool value)
	{
		UiManager.instance.ToggleOff(UiPanel.MainMenu);
		currentState = gameState;
		currentState.EnterState(this);
	}
}
