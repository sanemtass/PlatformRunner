using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalObstacle : MonoBehaviour
{
    public Transform pos1, pos2;
    public Transform startPos;
    public float speed;

    private Transform obstacleTransform;

    Vector3 nextPos;
    private void Start()
    {
        obstacleTransform = transform.GetChild(0);
        nextPos = startPos.position;
    }

    private void Update()
    {
        HorizontalObstacles();
    }
    public void HorizontalObstacles()
    {
        if (obstacleTransform.position == pos1.position)
        {
            nextPos = pos2.position;
        }

        if (obstacleTransform.position == pos2.position)
        {
            nextPos = pos1.position;
        }

        obstacleTransform.position = Vector3.MoveTowards(obstacleTransform.position, nextPos, speed * Time.deltaTime);
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}
