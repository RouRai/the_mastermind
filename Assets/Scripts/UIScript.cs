using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIScript : MonoBehaviour

{
    public TextMeshProUGUI itemsCollectedText;
    public TextMeshProUGUI doorsCollectedText;
    public TextMeshProUGUI healthText;
    public static UIScript instance { get; private set; }
    int doorNum = 0;
    int itemNum = 0;

    void Awake()

    {

        instance = this;

    }

    public void updateItems()
    {
        itemNum++;
        itemsCollectedText.text = "Items Collected: "+itemNum;
    }

    public void updateDoors()
    {
        doorNum++;
        doorsCollectedText.text = "Doors Collected: " + doorNum;
    }

    public void updateHealth(int x)
    {
        healthText.text = "Health: " + x;
    }
}