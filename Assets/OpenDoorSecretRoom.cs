using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorSecretRoom : MonoBehaviour
{
    public Animator doorAnimator;
    // Start is called before the first frame update

    public void OnTriggerEnter(Collider other)
    {
        doorAnimator.SetTrigger("openDoor");
    }
}
