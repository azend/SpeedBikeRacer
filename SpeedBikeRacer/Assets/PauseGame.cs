using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {

    public GameObject inGameObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.M))
        {
            BringUpMenu();
        }
	}

    void BringUpMenu()
    {
        inGameObject.SetActive(true);
        
        Time.timeScale = 0;
    }
}
