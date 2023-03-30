using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public TextMeshProUGUI message;
    // Update is called once per frame
    public void UpdateText(string promptmessage)
    {
        message.text = promptmessage;
    }
}
