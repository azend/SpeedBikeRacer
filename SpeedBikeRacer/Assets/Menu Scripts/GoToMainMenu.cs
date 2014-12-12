using UnityEngine;
using System.Collections;

public class GoToMainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.N))
        {
            returnToMainMenu();
        }
	}

    void returnToMainMenu()
    {
        Time.timeScale = 1;

        Application.LoadLevel(1);
    }
}
