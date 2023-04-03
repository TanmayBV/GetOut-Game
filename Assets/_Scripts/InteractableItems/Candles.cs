using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candles : MonoBehaviour,IInteractable
{
    bool Islight;
    private void Awake() {
        gameObject.layer = 6;
    }
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
