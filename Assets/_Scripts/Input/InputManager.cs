using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    InputActions inputActions;

    public Vector2 movementVar;
    public Vector2 mouseInput;
    private void OnEnable()
    {
        if (inputActions == null)
        {
            inputActions = new InputActions();

            //Getting Input
            inputActions.Player.PlayerMovement.performed += i => movementVar = i.ReadValue<Vector2>();
            inputActions.Player.PlayerMovement.canceled += i => movementVar = i.ReadValue<Vector2>();
            inputActions.Player.PlayerLook.performed += i => mouseInput = i.ReadValue<Vector2>();
            inputActions.Player.PlayerLook.canceled += i => mouseInput = i.ReadValue<Vector2>();
        }

        inputActions.Player.Enable();
    }

    private void OnDisable()
    {
        inputActions.Player.Disable();
    }

    public bool CanInteract()
    {
        return inputActions.Player.Interact.triggered;
    }
}
