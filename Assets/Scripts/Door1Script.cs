using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class door1Script : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)

    {
        HeroKnight controller = other.GetComponent<HeroKnight>();

        if (controller != null)
        {
            SceneManager.LoadScene("LevelTwo");
        }

    }
}
