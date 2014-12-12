using UnityEngine;
using System.Collections;

public class Deathstar : MonoBehaviour {
    int y = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            y = -15;
            rigidbody.MovePosition(new Vector3(-20, y, -5));
        }
	}
}
