using UnityEngine;
using System.Collections;

public class Deathstar : MonoBehaviour {
    int y = 0;
    public bool play = true;

    public GameObject changeAudio;
    public AudioClip clip;

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) && play == true)
        {
            y = -15;
            rigidbody.MovePosition(new Vector3(-20, y, -5));
            changeAudio.audio.clip = clip;
            play = false;
        }
	}
}
