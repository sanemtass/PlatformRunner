using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatformTrigger : MonoBehaviour
{
    [HideInInspector]public bool isPlatform;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isPlatform = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isPlatform = false;
        }
    }
}
