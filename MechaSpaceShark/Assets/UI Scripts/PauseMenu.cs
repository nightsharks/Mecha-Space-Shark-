using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    public GameObject PauseButton;
    public GameObject otherUI;

    //public void Awake()
    //{
    //    PauseMenuUI.SetActive(false);
    //}

    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        otherUI.SetActive(true);

        Debug.Log("setactive");
        Time.timeScale = 0f;
        GameIsPaused = true;
        PauseButton.SetActive(false);
    }
}
