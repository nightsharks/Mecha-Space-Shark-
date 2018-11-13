using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firebreathing : MonoBehaviour {

    public ParticleSystem Fire;
    public GameObject frontOfShark;
    public Transform FireSpawn;

    private void Start()
    {
        Fire.Pause();
    }
    void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            BreatheFire();
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            Fire.Stop();

        }
    }

    public void BreatheFire()
    {
        Fire.Play();
        Debug.Log("firebreathing");
    }
}
