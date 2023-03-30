using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour,IInteractable
{
    public void Interact()
    {
       Debug.Log("I Am Fan");
    }
}
