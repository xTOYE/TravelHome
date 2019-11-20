using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavmesh : MonoBehaviour
{
    public Transform waypointParent;
    public float waypointDistance = 5f;
    public float speed = 5;
    public NavMeshAgent agent;

    private Transform[] points;
    private int currentWaypoint = 1;

    void Start()
    {
        points = waypointParent.GetComponentsInChildren<Transform>();//gets the waypoints
    }

    void OnDrawGizmos()
    {
        points = waypointParent.GetComponentsInChildren<Transform>();

        if (points != null)
        {
            Gizmos.color = Color.red;//so they get colored red first
            for (int i = 1; i < points.Length - 1; i++)
            {
                Transform pointA = points[i];
                Transform pointB = points[i + 1];//next waypoint
                Gizmos.DrawLine(pointA.position, pointB.position);//draws line between waypoints
            }

            for (int i = 1; i < points.Length; i++)
            {
                Gizmos.DrawSphere(points[i].position, waypointDistance);//draw the radius of the waypoints for Debug
            }
        }
    }

    void Update()
    {
        Transform currentPoint = points[currentWaypoint];// Get current waypoint
        agent.SetDestination(currentPoint.position);// Check if disctance between waypoint is close

        float distance = Vector3.Distance(transform.position, currentPoint.position);
        if (distance <waypointDistance)
        {
            currentWaypoint++;// Switch to next waypoint
        }
    }
}
