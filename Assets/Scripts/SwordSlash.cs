using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSlash : MonoBehaviour
{

    Rigidbody2D rigidbody2d;

    // Start is called before the first frame update
    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.magnitude > 5.0f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        EnemyMove enemy = other.GetComponent<EnemyMove>();
        if (enemy == null) return;
        // enemy.Slashed(2);
        Destroy(gameObject);
    }

    public void Slash(Vector2 direction, float force)
    {
        rigidbody2d.AddForce(direction * force);
    }
}