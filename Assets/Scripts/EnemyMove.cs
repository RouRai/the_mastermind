using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{


    public Transform[] waypoints;
    int cur = 0;

    public float speed = 0.3f;
    public int damageDealt = 2;
    public int health;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
            rb.MovePosition(p);
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

        controller.ChangeHealth(-1 * damageDealt);
    }

    public void Slashed(int damage)
    {
        health -= damage;
        if (health < 1)
        {
            Destroy(gameObject);
        }
    }
}