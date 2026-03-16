using UnityEngine;
using UnityEngine.InputSystem;

public class QuitGame : MonoBehaviour
{
    public InputActionReference quitAction;

    private void OnEnable()
    {
        quitAction.action.Enable();
        quitAction.action.performed += OnQuit;
    }

    private void OnDisable()
    {
        quitAction.action.performed -= OnQuit;
        quitAction.action.Disable();
    }

    private void OnQuit(InputAction.CallbackContext context)
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }
}