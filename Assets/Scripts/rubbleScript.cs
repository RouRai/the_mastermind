using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rubbleScript : MonoBehaviour
{
    public GameObject ui;
    // Start is called before the first frame update
   void breakRubble()
    {   
        UIScript control = ui.GetComponent<UIScript>();
        control.setDoorNum();
        Destroy(gameObject);
    }
}
