using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onClick : MonoBehaviour {

	public void exitGame () {
        Application.Quit();
	}
	
    public void startGame ()
    {
        SceneManager.LoadScene(sceneBuildIndex:1);
    }

    public void mainMenu ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
}
