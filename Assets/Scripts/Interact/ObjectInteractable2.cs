using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteractable2 : Interactable
{
    protected override void Interact()
    {
        Destroy(gameObject);
    }
}
