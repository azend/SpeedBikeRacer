using UnityEngine;
using System.Collections;

public class TextScroller : MonoBehaviour {

	public int speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.localPosition += new Vector3 (0, 1 * speed * Time.deltaTime, 0);
	}
}
