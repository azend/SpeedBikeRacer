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
        Object[] inGameObject;
        GameObject enableObject;
        int x = 0;

        inGameObject = Resources.FindObjectsOfTypeAll(typeof(GameObject));

        while (x < inGameObject.Length)
        {
            if (inGameObject[x].name == "InGameManu")
            {
                enableObject = (GameObject)inGameObject[x];
                enableObject.SetActive(true);
            }
            x++;
        }
        
        Time.timeScale = 0;
    }
}
