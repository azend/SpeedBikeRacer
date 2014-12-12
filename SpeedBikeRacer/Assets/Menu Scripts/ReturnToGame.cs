using UnityEngine;
using System.Collections;

public class ReturnToGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.B))
        {
            returnToGame();
        }
	}

    void returnToGame()
    {
        Time.timeScale = 1;
        GameObject inGameMenu = GameObject.Find("InGameMenu");
        inGameMenu.SetActive(false);
    }
}
