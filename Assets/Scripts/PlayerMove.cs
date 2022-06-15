using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    Vector3 firstPos, endPos;

    public CharacterController controller;

    public float speed;
    public float playerSpeed;
    public float gravity = -9.81f;
    public float checkRadius = 0.5f;
    [HideInInspector]
    public float xMovementValue = 0f; 

    public LayerMask checkLayerMask;

    [HideInInspector]
    public Rigidbody rb;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
    }

    public void Move()
    {
        //Control of the character's contact with the ground
        bool isGround = Physics.CheckSphere(transform.position, checkRadius, checkLayerMask);
        if (isGround)
        {
            gravity = 0f; //If the character is on the ground we will not pull down
        }
        else if (!isGround)
        {
            gravity = -9.8f; //While the character is in the air we need to add gravity so that he falls down
        }

        TranslateMovement(xMovementValue);
        
        if (Input.GetMouseButtonDown(0))
        {
            firstPos = Input.mousePosition;
        }

        else if (Input.GetMouseButton(0))
        {
            endPos = Input.mousePosition;
            float differentX = endPos.x - firstPos.x;
            transform.Translate(differentX * Time.deltaTime * playerSpeed / 100f, 0f, 0f);
        }
        if (Input.GetMouseButtonUp(0))
        {
            firstPos = Vector3.zero;
            endPos = Vector3.zero;
        }
    }
    public void Die()
    {
        //Restart the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(transform.position, checkRadius);
    }

    public void TranslateMovement(float x)
    {
        //Moves continuously in the z-axis
        transform.Translate(x, gravity * Time.deltaTime, speed * Time.deltaTime);
    }
}
