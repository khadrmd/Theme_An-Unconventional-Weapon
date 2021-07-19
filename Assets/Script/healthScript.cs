using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthScript : MonoBehaviour
{
    public static int healthValue = 3;
    Text health;

    private void Start()
    {
        health = GetComponent<Text>();
    }

    private void Update()
    {
        health.text = "HP: " + healthValue;
    }
}
