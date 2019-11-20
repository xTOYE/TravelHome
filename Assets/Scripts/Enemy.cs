using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform waypointParent;
    public float waypointDistance = 5f;
    public float speed = 5;

    private Transform[] points;
    private int currentWaypoint = 1;
    private int previousWaypoint = -1;
    private bool isForward = true;

    void Start()
    {
        points = waypointParent.GetComponentsInChildren<Transform>();
    }

    void OnDrawGizmos()
    {


        if (points != null)
        {
            points = waypointParent.GetComponentsInChildren<Transform>();
            Gizmos.color = Color.red;//setting the clolor of the gizmos to red
            for (int i = 1; i < points.Length - 1; i++)
            {
                Transform pointA = points[i];
                Transform pointB = points[i + 1];
                Gizmos.DrawLine(pointA.position, pointB.position);
            }

            for (int i = 1; i < points.Length; i++)
            {
                Gizmos.DrawSphere(points[i].position, waypointDistance);
            }
        }
    }

    void Update()
    {
        
        Transform currentPoint = points[currentWaypoint];// Get current waypoint
        transform.position = Vector3.MoveTowards(transform.position, currentPoint.position, speed * Time.deltaTime);// Move towards current waypoint
        float distance = Vector3.Distance(transform.position, currentPoint.position);// Check if disctance between waypoint is close
        if (distance < waypointDistance)
        {
            if (isForward)
            {
                currentWaypoint++;
                if(currentWaypoint >= points.Length)// Switch to next waypoint
                {
                    currentWaypoint = points.Length - 1;
                    isForward = false;
                }
            }
            else
            {
                currentWaypoint--;
                if (currentWaypoint<2)
                {
                    currentWaypoint = 1;
                    isForward = true;
                }
            }
        }
    }
}
