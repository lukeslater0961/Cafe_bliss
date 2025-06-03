using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class MenuBaseState
{
    public abstract void EnterState(MenuStateManager menu);
    public abstract void HandleEscape(MenuStateManager menu, Scene currentScene);
}
