using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class SceneLoader : MonoBehaviour
{
    public void LoadSceneByName(string sceneName)
    {
        if (Gamepad.current != null) InputSystem.ResetHaptics();
        SceneManager.LoadScene(sceneName);
    }
}