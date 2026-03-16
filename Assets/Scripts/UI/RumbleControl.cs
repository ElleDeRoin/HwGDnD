using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Haptics;

public class RumbleControl : MonoBehaviour
{
    //Ends controller rumble on nongame scenes
    void Start()
    {
        if (Gamepad.current != null) 
            InputSystem.ResetHaptics();
    }
}
