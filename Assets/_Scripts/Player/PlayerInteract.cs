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
        cam = GetComponent<PlayerLocomotion>().cam;
    }

    public void Update()
    {
        playerUI.UpdateText(string.Empty);
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * rayDistance);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, rayDistance))
        {
            if (hitInfo.collider != null)
            {
                var interactable = hitInfo.collider.GetComponent<IInteractable>();
                if(interactable == null) return;
                playerUI.UpdateText("Press E");
                if(!Input.GetKeyDown(KeyCode.E)) return;
                interactable.Interact();
            }
        }
    }
}
