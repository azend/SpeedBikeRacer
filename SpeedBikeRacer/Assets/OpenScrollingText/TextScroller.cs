using UnityEngine;
using System.Collections;

public class TextScroller : MonoBehaviour {

	public int speed;
    float myTimer = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.localPosition += new Vector3 (0, 1 * speed * Time.deltaTime, 0);
        
        myTimer += Time.deltaTime;

        if (myTimer > 90)
        {
            Application.LoadLevel(1);
        }
	}
}
