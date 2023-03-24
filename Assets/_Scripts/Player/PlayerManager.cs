using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    InputManager inputManager;
    PlayerLocomotion playerLocomotion;
    PlayerRotation playerRotation;
    PlayerInteract playerInteract;

    //Player Components
    Rigidbody rb;
    float delta;


    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        playerLocomotion = GetComponent<PlayerLocomotion>();
        playerRotation = GetComponent<PlayerRotation>();
        playerInteract = GetComponent<PlayerInteract>();

        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;    }
    private void Update()
    {
       delta = Time.deltaTime;
       // playerInteract.PlayerInteractMenthod(inputManager.CanInteract());
    }
    private void FixedUpdate()
    {
        playerLocomotion.Movement(inputManager.movementVar, rb, delta);
    }
    private void LateUpdate()
    {
        playerRotation.PlayerLook(inputManager.mouseInput, delta);
    }
}
