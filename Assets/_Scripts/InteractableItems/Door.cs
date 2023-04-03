using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    Animator anim;
    private void Awake() {
        anim = GetComponent<Animator>();
        gameObject.layer = 6;
    }
    bool isOpen = false;
    public void Interact()
    {
        DoorMovement();
    }

    void DoorMovement()
    {
        isOpen = !isOpen;
       anim.SetTrigger("DoorTrigger");
    }
}
