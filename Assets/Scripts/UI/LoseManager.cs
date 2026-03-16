using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class LoseManager : MonoBehaviour
{
    public bool lost = false;

    public void ShowLoseScreen()
    {
        lost = true;
        
        // Reset haptics if a gamepad is connected
        if (Gamepad.current != null)
            InputSystem.ResetHaptics();
        
        // Pause the game
        Time.timeScale = 0f;

        // Load the separate lose scene
        SceneManager.LoadScene("NewLoseScene");
    }

}