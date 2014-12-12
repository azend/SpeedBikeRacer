using UnityEngine;
using System.Collections;

public class WinLevel : MonoBehaviour {

    public GameObject inGameMenu;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FinishLine")
        {
            Time.timeScale = 0;
            showWinnerMenu();
        }
    }

    void showWinnerMenu()
    {
        inGameMenu.SetActive(true);
    }
}
