using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class Timer : MonoBehaviour {

    public float timer = 0;
    public Text counter;

  void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        timer += Time.deltaTime;
        counter.text = "Time: " + timer.ToString("F2");
    }

}
