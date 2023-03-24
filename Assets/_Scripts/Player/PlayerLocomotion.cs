using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{
    Rigidbody rdbody;

    //Player Movement PUblic Variables
    [Header("Player Movement")]
    [SerializeField] float speed = 4f;

    //Player Movement private Var
    private float xInput;
    private float zInput;
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
}
