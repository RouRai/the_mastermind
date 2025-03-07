using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIScript : MonoBehaviour

{
    public TextMeshProUGUI doorsOpenedText;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI cherriesText;
    public static UIScript instance { get; private set; }
    int itemNum = 0;

    void Awake()

    {

        instance = this;

    }

    void Update(){
        // Create a temporary reference to the current scene.
		Scene currentScene = SceneManager.GetActiveScene ();

		// Retrieve the name of this scene.
		string sceneName = currentScene.name;
        if(sceneName == "LevelTwo"){
            doorsOpenedText.text = "Doors Opened: " + 1;
        }else if(sceneName == "LevelThree"){
            doorsOpenedText.text = "Doors Opened: " + 2;
        }
    }
    
    public void updateCherries(int x)
    {
        cherriesText.text = "Cherries: " + x;
    }
    
    public void setDoorNum(){
        Debug.Log("third door");
        doorsOpenedText.text = "Doors Opened: 3";
    }

    public void updateHealth(int x)
    {
        healthText.text = "Health: " + x;
    }
}