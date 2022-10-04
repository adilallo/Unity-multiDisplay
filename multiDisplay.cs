using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiDisplay : MonoBehaviour
{
    void Start()
    {
        // Switch to 5760 x 1080 full-screen
        Screen.SetResolution(1920, 1080, true);
        Debug.Log("displays connected: " + Display.displays.Length);
        // Display.displays[0] is the primary, default display and is always ON, so start at index 1.
        // Check if additional displays are available and activate each.

        for (int i = 1; i < Display.displays.Length; i++)
        {
            Display.displays[i].Activate(1920, 1080, 60);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }


}
