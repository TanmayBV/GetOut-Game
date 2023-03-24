using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public bool UseEvents;

    public string PromptMessage;

    public void BaseInteract()
    {
        if (UseEvents)
            GetComponent<InteractionEvent>().onInteract.Invoke();

        Interact();
    }

    protected virtual void Interact()
    {

    }
    
}
