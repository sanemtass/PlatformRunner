using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FinishLine : MonoBehaviour
{
    public bool finishLine = false;

    public UnityEvent onFinishEvent;

    private Animator anim;

    private void Start()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            anim = other.gameObject.GetComponent<Animator>();
            anim.SetBool("finishLine", true);
            PlayerMove moveScript = other.GetComponent<PlayerMove>(); //içeriye gelen karakterin icindeki playermove scriptini degiskene atadik.
            if (moveScript != null)
                moveScript.enabled = false;
            onFinishEvent.Invoke();
            
        }

    }

}
