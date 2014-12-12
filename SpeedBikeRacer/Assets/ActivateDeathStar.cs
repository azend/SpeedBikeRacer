using UnityEngine;
using System.Collections;

public class ActivateDeathStar : MonoBehaviour {

    public GameObject deathstar;
	// Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            deathstar.SetActive(true);
        }
    }
}
