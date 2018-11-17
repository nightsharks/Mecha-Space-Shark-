using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireParticles : MonoBehaviour {

    private void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Obstacle"))
            {
            Debug.Log("particle hit");
            other.SetActive(false);
        }
    }
}
