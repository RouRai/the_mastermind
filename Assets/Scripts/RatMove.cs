using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatMove : MonoBehaviour
{


    public Transform[] waypoints;
    int cur = 0;

    public float speed = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate () {
    // Waypoint not reached yet? then move closer
    if (transform.position != waypoints[cur].position) {
        Vector2 p = Vector2.MoveTowards(transform.position,
                                        waypoints[cur].position,
                                        speed);
        Debug.Log(waypoints[cur].position);
        GetComponent<Rigidbody2D>().MovePosition(p);
        Debug.Log(waypoints[cur].position);
        Debug.Log(transform.position);
    }
    // Waypoint reached, select next one
    else cur = (cur + 1) % waypoints.Length;
}

}
