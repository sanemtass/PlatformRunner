using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollider : MonoBehaviour
{
    private Vector3 startPoint;
    private PlayerMove _playerMove;
    

    private void Awake()
    {
        startPoint = GameObject.FindGameObjectWithTag("StartPoint").transform.position;
        _playerMove = GetComponent<PlayerMove>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            _playerMove.enabled = false;
            transform.position = startPoint;
            Invoke(nameof(ActiveCharacter), 1f);
            print("carpisti");
        }
    }

    void ActiveCharacter()
    {
        _playerMove.enabled = true;
    }
}
