using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public bool UseEvents;
    [SerializeField]
    public string promptMessage;

    public void BaseInteract()
    {
        if(UseEvents)
        {
            GetComponent<InteractionEvent>().OnInteract.Invoke();
        }
        BottleInteract();
        KeyPadInteract();
    }

    protected virtual void KeyPadInteract() {}
    protected virtual void BottleInteract() {}
}
