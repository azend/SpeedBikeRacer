using UnityEngine;
using System.Collections;

public class UpdateTimer : MonoBehaviour {
    public float myTimer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        myTimer += Time.deltaTime;
	}

    void OnGUI()
    {
        GUI.Box(new Rect(Screen.width - 190, 5, 180, 30), "Time: " + myTimer.ToString("f2"));
    }
}
