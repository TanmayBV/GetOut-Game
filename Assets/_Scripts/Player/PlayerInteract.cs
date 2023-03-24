using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    PlayerUI playerUI;

    private Camera cam;

    [SerializeField] 
    private float rayDistance = 4f;
    [SerializeField]
    private LayerMask mask;

    private void Start()
    {
        playerUI = GetComponent<PlayerUI>();
        cam = GetComponent<PlayerRotation>().cam;
    }

    public void PlayerInteractMenthod(bool canInteract)
    {
        playerUI.UpdateText(string.Empty);
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * rayDistance);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, rayDistance, mask))
        {
            if (hitInfo.collider.GetComponent<Interactable>() != null)
            {
                Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
                playerUI.UpdateText(interactable.PromptMessage);
                if (canInteract)
                {
                    interactable.BaseInteract();
                }
            }
        }
    }
}
