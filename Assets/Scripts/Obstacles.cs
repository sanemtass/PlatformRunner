using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    PlayerMove playerMove;
    
    void Start()
    {
        playerMove = GameObject.FindObjectOfType<PlayerMove>();
        
    }

    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.name=="Player")
        {
            // Kill the player
            playerMove.Die();
        }

    }

}
