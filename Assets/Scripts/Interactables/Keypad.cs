using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : Interactable
{

    private bool DoorOpen;
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void KeyPadInteract()
    {
        DoorOpen = !DoorOpen;
        door.GetComponent<Animator>().SetBool("isOpen", DoorOpen);
    }
}
