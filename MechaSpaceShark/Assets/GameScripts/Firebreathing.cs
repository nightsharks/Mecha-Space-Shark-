using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firebreathing : MonoBehaviour {

    public ParticleSystem Fire;
    public GameObject frontOfShark;
    public Transform FireSpawn;
    public static bool canBreathe;
    public static bool hasBreathed;
    private IEnumerator coroutine;

    private void Start()
    {
        Fire.Stop();
        canBreathe = false;
        hasBreathed = false;
    }
    void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            BreatheFire();
        }
    }

    public void BreatheFire()
    {
        if (canBreathe)
        {
            Fire.Play();
            var em = Fire.emission;
            em.enabled = true;
            hasBreathed = true;
            coroutine = fireTimer();
            StartCoroutine(coroutine);

        }
        Debug.Log("firebreathing");
    }

    public void StopFire()
    {         
        Fire.Stop();
        var em = Fire.emission;
        em.enabled = false;
        canBreathe = false;
    }


    IEnumerator fireTimer()
    {
        yield return new WaitForSeconds(1f);
        StopFire();
        hasBreathed = false;
    }
}
