using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject gameoverText;

    private void Start()
    {
        gameoverText.SetActive(false);
    }

    private void Update()
    {
        if(Time.timeScale == 0f)
        {
            gameoverText.SetActive(true);
        }
    }
}
