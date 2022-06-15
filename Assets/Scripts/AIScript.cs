using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIScript : MonoBehaviour
{
    NavMeshAgent myAgent;
    public Transform [] wayPoints;
    private int destPoint = 0;

    void Awake()
    {
        myAgent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        PickWayPoint();
    }
    void Update()
    {
        if (myAgent.remainingDistance < .25f)
        {
            PickWayPoint();
        }
    } 
    void PickWayPoint()
    {
        //int randomWPNumber;
        //randomWPNumber = Random.Range(0, wayPoints.Length);


        myAgent.SetDestination(wayPoints[destPoint].position);
        destPoint = (destPoint + 1);
    }
}
