using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    bool isOpen = false;
    public void Interact()
    {
        DoorMovement();
    }

    void DoorMovement()
    {
        isOpen = !isOpen;
       
    }
}
