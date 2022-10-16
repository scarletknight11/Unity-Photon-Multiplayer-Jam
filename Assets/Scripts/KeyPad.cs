using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPad : Interactable {

    [SerializeField]
    private GameObject door;
    private bool doorOpen;
    private bool doorclose;

    private float countdown = 3f;

    public void Interaction()
    {
        Interact();
    }

    //function to design interaction
    protected override void Interact()
    {
        doorOpen = !doorOpen;
        door.GetComponent<Animator>().SetBool("IsOpen2", doorOpen);
    }

    protected override void closedoor()
    {
        doorclose = true;
        door.GetComponent<Animator>().SetBool("close", doorclose);
    }
}
