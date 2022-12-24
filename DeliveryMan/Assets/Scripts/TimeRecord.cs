using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeRecord : MonoBehaviour
{
    public static float time = 0f;
    bool updateTimer = false;

    TMPro.TextMeshProUGUI textUI;

    void Start()
    {
        updateTimer = true;
        textUI = GetComponent<TMPro.TextMeshProUGUI>();
    }

    void Update()
    {
        if (updateTimer) {
            time += Time.deltaTime;
            displayTime();
        }
        
    }

    private void displayTime()
    {
        
        textUI.text = TimeSpan.FromSeconds(time).ToString("mm\\:ss\\.fff");
    }
}
