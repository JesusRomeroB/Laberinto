using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    List<Tile> path;
    private float moveSpeed = 2f;
    public Vector2 GetPosition => transform.position;

    private int waypointIndex = 0;
    private Transform Player;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    public void Init(Player player)
    {
         Player = player.transform;
    }

    public void SetPath(List<Tile> path)
    {
        //ResetPosition();
        waypointIndex = 0;
        this.path = path;
    }

    public void ResetPosition()
    {
        transform.position = new Vector2(0, 0);
    }

    private void Move()
    {
        // If player didn't reach last waypoint it can move
        // If player reached last waypoint then it stops
        if (path == null)
            return;

        if (waypointIndex <= path.Count - 1)
        {

            // Move player from current waypoint to the next one
            // using MoveTowards method
            transform.position = Vector3.MoveTowards(transform.position,
               path[waypointIndex].transform.position,
               moveSpeed * Time.deltaTime);

            // If player reaches position of waypoint he walked towards
            // then waypointIndex is increased by 1
            // and player starts to walk to the next waypoint
            if (transform.position == path[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(Player.position);
        //Move();
    }
}
