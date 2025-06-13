using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{ 
	public static	InputHandler instance;
	private			InputAction escapeAction;
	private			InputAction interactAction;

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
		escapeAction = InputSystem.actions.FindAction("Escape");
		interactAction = InputSystem.actions.FindAction("Interact");
	}

	void Update()
	{
		HandleInput();
	}


	public void HandleInput()
	{
		if (escapeAction.WasPressedThisFrame())
			MenuStateManager.instance.HandleEscapeInput(false);
		else if (interactAction.WasPressedThisFrame())
			QuestsManager.instance.AddQuest();
	}
}
