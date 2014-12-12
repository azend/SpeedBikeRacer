using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {

    void FixedUpdate()
    {
        if (Time.timeScale != 0)
        {
            Time.timeScale = 0;
        }
    }
}
