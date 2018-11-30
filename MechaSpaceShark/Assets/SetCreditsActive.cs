using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class SetCreditsActive : MonoBehaviour {

    public GameObject credits;

    private void Start()
    {
        credits.SetActive(false);
    }
    public void showCredits()
    {
        if (credits.activeSelf == false)
        {
            credits.SetActive(true);
            EventSystem.current.SetSelectedGameObject(null);
        }

        else
        {
            credits.SetActive(false);
            EventSystem.current.SetSelectedGameObject(null);
        }
    }
}
