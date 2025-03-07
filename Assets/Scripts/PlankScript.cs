using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter2D (Collision2D other)
    {
        HeroKnight controller = other.collider.GetComponent<HeroKnight>();
        
        if (controller == null)
        {
            return;
        }

        GetComponent<Rigidbody2D>().gravityScale = 1;
    }
}
