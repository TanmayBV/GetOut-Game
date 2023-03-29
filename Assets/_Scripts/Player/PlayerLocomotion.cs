using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{
    public Camera cam;
    Rigidbody rdbody;

    //Player Movement PUblic Variables
    [Header("Player Movement")]
    [SerializeField] float speed = 4f;

    //Movement Private Variables
    private float xInput;
    private float zInput;

    [Header("Player Rotation")]
    [SerializeField] float sensitivity = 10f;
    //Rotation Private Variables
    private float xRotation;

    //Player Movement Function 
    public void Movement(Vector2 dir, Rigidbody rb, float delta)
    {
        rdbody = rb;
        xInput = dir.x;
        zInput = dir.y;

        Vector3 move = Vector3.zero; ;
        move = transform.right * xInput + transform.forward * zInput;
        move.Normalize();

        rdbody.velocity = move * speed * delta;
    }

    //Player Rotation Function
    public void PlayerLook(Vector2 dir, float delta)
    {
        float mouseX = dir.x;
        float mouseY = dir.y;

        xRotation -= (mouseY * delta) * sensitivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        transform.Rotate(Vector3.up * (mouseX * delta) * sensitivity);
    }

}
