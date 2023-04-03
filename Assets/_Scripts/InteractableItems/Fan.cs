using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour,IInteractable
{
    private void Awake() {
        gameObject.layer = 6;
    }
    public void Interact()
    {
       Debug.Log("I Am Fan");
    }
}
