using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMove : MonoBehaviour
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
        if (Vector2.Distance(transform.position, waypoints[cur].position) > 0.1) {
            Vector2 p = Vector2.MoveTowards(transform.position,
                                            waypoints[cur].position,
                                            speed);
            GetComponent<Rigidbody2D>().MovePosition(p);
            Debug.Log(waypoints[cur].position);
            Debug.Log(transform.position);
            Debug.Log(cur);
            Debug.Log((cur + 1) % waypoints.Length);
        }
    // Waypoint reached, select next one
        else cur = (cur + 1) % waypoints.Length;
    }
    
    void OnTriggerEnter2D (Collider2D other)
    {
        HeroKnight controller = other.GetComponent<HeroKnight>();
        
        if (controller == null)
        {
            return;
        }

        controller.ChangeHealth(-2);
    }

}
