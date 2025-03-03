using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door2Script : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)

    {
        HeroKnight controller = other.GetComponent<HeroKnight>();

        if (controller != null)

        {

            Debug.Log("knight hit it");

        }

    }
}
