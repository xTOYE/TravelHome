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
            Gizmos.color = Color.red;
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
        // Get current waypoint
        Transform currentPoint = points[currentWaypoint];
        // Move towards current waypoint
        transform.position = Vector3.MoveTowards(transform.position, currentPoint.position, speed * Time.deltaTime);
        // Check if disctance between waypoint is close
        float distance = Vector3.Distance(transform.position, currentPoint.position);
        if (distance < waypointDistance)
        {
            if (isForward)
            {
                // Switch to next waypoint
                currentWaypoint++;
                if(currentWaypoint >= points.Length)
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

        // >>ERROR HANDLING<<
        // if currentWayPoint is outside array length
        // reset back to 1
    }
    void update()
    {


    }
}
