using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class onClick : MonoBehaviour {

    public void exitGame () {
        Application.Quit();
	}
	
    public void startGame ()
    {
        SceneManager.LoadScene(sceneBuildIndex:1);
        Obstacle.CollideWithAsteroid = false;
        Time.timeScale = 1f;
    }

    public void mainMenu ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Obstacle.CollideWithAsteroid = false;
        Time.timeScale = 1f;
    }


}
