using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float thrust = 5.0f;
    public float forceAmount = 100f;


    private void Update()
    {
        transform.Rotate(0, 1, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<CharacterController>().Move(Vector3.back * forceAmount);
        }
    }

    
}
