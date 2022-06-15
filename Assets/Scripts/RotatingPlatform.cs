using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    public enum RotateDirection
    {
        left,right
    };

    public RotateDirection rotateDirection;
    public Vector3 vector;
    public GameObject rotatingPlatform;
    [SerializeField] private float speed;

    private RotatingPlatformTrigger rpt;
    private PlayerMove playerMove;
    private int direction = 1;


    private void Awake()
    {
        rpt = GetComponentInChildren<RotatingPlatformTrigger>();
        playerMove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();

        switch (rotateDirection)
        {
            case RotateDirection.left:
                direction = -1;
                break;
            case RotateDirection.right:
                direction = 1;
                vector *= -1f;
                break;
            default:
                break;
        }
    }

    void Update()
    {
        rotatingPlatform.transform.Rotate(vector * speed);

        if (rpt.isPlatform)
        {
            playerMove.controller.Move(Vector3.right * direction * speed * Time.deltaTime);
        }
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            print("Üzerinde");
        }
    }


}
