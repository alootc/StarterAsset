using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    public float distance = 1.5f;
    public LayerMask mask;

    private StarterAssetsInputs input;
    private Camera cam;
    private bool is_interact;

    public Text text_message;


    void Start()
    {
        input = GetComponent<StarterAssetsInputs>();
        cam = Camera.main;

    }

    
    void Update()
    {
        text_message.text = string.Empty;

        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);

        if(Physics.Raycast(ray, out RaycastHit hitInfo, distance, mask))
        {
            Interactable interactable = hitInfo.collider.GetComponent<Interactable>();

            if (interactable != null)
            {
                text_message.text = interactable.prompt_message;

                if (input.interact && !is_interact)
                {
                    is_interact = true;
                    interactable.BaseInteract();
                }
                

            }
            if(!input.interact) is_interact = false;
            
        }

        

    }
}
