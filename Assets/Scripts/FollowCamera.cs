using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FollowCamera : MonoBehaviour
{
    public Transform followTarget;
    public Vector3 offset;
    public float smoothTime;
    public float cameraFinishTime = 2f;

    private bool isCamera = true;

    private Transform paintingPoint;

    private void Start()
    {
        isCamera = true;
        paintingPoint = GameObject.FindGameObjectWithTag("Painting Point").transform;
    }

    private void Update()
    {
        if (isCamera)
        {
            Vector3 targetPos = followTarget.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPos, smoothTime * Time.deltaTime);
        }

        
    }

    public void CameraFinishAnim()
    {
        isCamera = false;
        transform.DOMove(paintingPoint.position, cameraFinishTime);
        transform.DORotate(new Vector3(-25, 0, 0),cameraFinishTime);
        
    }
}
