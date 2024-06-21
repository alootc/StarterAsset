using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteractable : Interactable
{
    
    void Start()
    {
        
    }

    protected override void Interact()
    {
        Debug.Log("objecto interactuado");
    }    
}
