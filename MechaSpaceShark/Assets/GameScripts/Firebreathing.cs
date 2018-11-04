using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firebreathing : MonoBehaviour {

    public GameObject Fire;
    public Transform FireSpawn;

    void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            BreatheFire();
        }
    }

    public void BreatheFire()
    {
        var flame = (GameObject)Instantiate (Fire, FireSpawn.position, FireSpawn.rotation);

        Destroy(flame, .5f);
    }
}
