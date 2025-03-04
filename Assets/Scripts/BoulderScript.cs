using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderScript : MonoBehaviour
{
    
    Rigidbody2D rigidbody2d;
    
    // Start is called before the first frame update
    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }
    
    void OnCollisionEnter2D (Collision2D other)
    {
        HeroKnight hero = other.collider.GetComponent<HeroKnight>();
        if (hero != null)
        {
            hero.ChangeHealth(-5);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    
}
