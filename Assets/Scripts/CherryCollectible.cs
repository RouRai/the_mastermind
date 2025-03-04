using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryCollectible : MonoBehaviour
{

    void OnTriggerEnter2D (Collider2D other)
    {
        HeroKnight controller = other.GetComponent<HeroKnight>();
        
        if (controller == null)
        {
            return;
        }

        if (controller.currentHealth >= controller.maxHealth)
        {
            return;
        }

        controller.ChangeHealth(1);
        Destroy(gameObject);
    }
}
