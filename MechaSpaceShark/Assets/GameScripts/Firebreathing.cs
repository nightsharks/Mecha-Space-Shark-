using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firebreathing : MonoBehaviour {

    public ParticleSystem Fire;
    public GameObject frontOfShark;
    public Transform FireSpawn;

    private void Start()
    {
        Fire.Stop();
    }
    void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            BreatheFire();
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            StopFire();

        }
    }

    public void BreatheFire()
    {
        Fire.Play();
        var em = Fire.emission;
        em.enabled = true;
        Debug.Log("firebreathing");
    }

    public void StopFire()
    {          
            Fire.Stop();
            var em = Fire.emission;
            em.enabled = false;
    }
}
