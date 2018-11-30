using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour {

    public List<AudioClip> crystalPickup;
    public AudioSource crystalPlaySource;
	
	void Update () {
		
        if(Consumable.CollideWithFood)
        {
            if (Firebreathing.canBreathe == false)
            {
                crystalPlaySource.PlayOneShot(crystalPickup[0]);
            }
            else
            {
                crystalPlaySource.PlayOneShot(crystalPickup[1]);
            }

        }

	}

}
