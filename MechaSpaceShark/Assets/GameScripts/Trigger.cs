using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Apple"))
        {
            other.gameObject.SetActive(false);
            Debug.Log("apple");
        }

        else if (other.gameObject.CompareTag("Obstacle"))
        {
            other.gameObject.SetActive(false);
            Debug.Log("rock");
        }
    }
}
