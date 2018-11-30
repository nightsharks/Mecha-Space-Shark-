using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButton : MonoBehaviour {

    public GameObject PauseMenuUI;
    public GameObject PauseButton;
    public Canvas pauseCanvas;
    public void resumeClick()
    {
        PauseMenuUI.SetActive(false);
        pauseCanvas.gameObject.SetActive(false);
        Time.timeScale = 1f;
        
        PauseButton.SetActive(true);
    }
}
