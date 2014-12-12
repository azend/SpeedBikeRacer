using UnityEngine;
using System.Collections;

public class RestartLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R))
        {
            restartLevel();
        }
	}

    void restartLevel()
    {
        int level;

        Time.timeScale = 1;

        level = Application.loadedLevel;
        Application.LoadLevel(level);
    }
}
