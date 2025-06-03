using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{ 
	public static	InputHandler instance;
	private			InputAction escapeAction;

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
	}

	void Update()
	{
		HandleInput();
	}


	public void HandleInput()
	{
		if (escapeAction.WasPressedThisFrame())
			MenuStateManager.instance.HandleEscapeInput(false);
	}
}
