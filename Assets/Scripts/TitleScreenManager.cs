using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TitleScreenManager : MonoBehaviour
{
    public PlayerInputActions input = null;
    // Start is called before the first frame update
    void Awake()
    {
        input = new PlayerInputActions();
    }

    void OnEnable()
    {
        input.Player.Any.performed += OnAnyKeyPressed;
        input.Enable();
    }
    void OnDisable()
    {
        input.Player.Any.performed -= OnAnyKeyPressed;
        input.Disable();
    }
    
    private void OnAnyKeyPressed(InputAction.CallbackContext value)
    {
        Debug.Log("A key waas pressed : ");
        Debug.Log(value.control.name);
    }
}
