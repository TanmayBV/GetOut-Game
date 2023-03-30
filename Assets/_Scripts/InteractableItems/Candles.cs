using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candles : MonoBehaviour,IInteractable
{
    bool Islight;
    public void Interact()
    {
        Burn();
    }

    void Burn()
    {
        Islight = !Islight;
        transform.GetChild(0).gameObject.SetActive(Islight);
    }
}
