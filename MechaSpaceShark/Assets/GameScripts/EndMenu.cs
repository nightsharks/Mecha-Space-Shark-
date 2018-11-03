using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMenu : MonoBehaviour
{
    public GameObject EndMenuUI;

    public void Start()
    {
        EndMenuUI.SetActive(false);
    }

    void Update()
    {
        
        if(Trigger.CollideWithRock)
        {
            EndMenuUI.SetActive(true);
            Time.timeScale = 0f;
        }

    }
}
