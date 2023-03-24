using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public Camera cam;
    private float xRotation;

    [Header("Mouse stats")]
    [SerializeField] float sensitivity = 10f;

    //private
    float mouseX;
    float mouseY;

    public void PlayerLook(Vector2 dir, float delta)
    {
        mouseX = dir.x;
        mouseY = dir.y;

        xRotation -= (mouseY * delta) * sensitivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        transform.Rotate(Vector3.up * (mouseX * delta) * sensitivity);
    }

}
