using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {

    //Tutorial audioclips
    public AudioClip tutorialAudio_1;
    //Play tutorial bool's
    public bool Play_tutorialAudio_1;

    // Use this for initialization
    void Awake()
    {
        Play_tutorialAudio_1 = true;
    }
    void Play_TutorialAudio_1()
    {
        if (Play_tutorialAudio_1)
        {
            Play_tutorialAudio_1 = false; // set to false so that it doesn't do this every frame
            audio.clip = tutorialAudio_1;
            audio.volume = 100;
            audio.Play();
        }
    }

    void FixedUpdate()
    {
        if (Time.timeScale != 0)
        {
            Time.timeScale = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Play_TutorialAudio_1();
    }
}
