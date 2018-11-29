using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour {

    public List<AudioClip> crystalPickup;
    public AudioSource crystalPlaySource;
    //int score;

	void Start () {
       // score = 0;
	}
	

	void Update () {
		
        if(Consumable.CollideWithFood)
        {
            if (Firebreathing.canBreathe == false)
            {
                crystalPlaySource.PlayOneShot(crystalPickup[0]);
            }
            else
            {
                crystalPlaySource.PlayOneShot(crystalPickup[4]);
            }
            //score++;
            //if (score == 1)
            //{
            //    crystalPlaySource.PlayOneShot(crystalPickup[0]);
            //}

            //else if (score == 2)
            //{
            //    crystalPlaySource.PlayOneShot(crystalPickup[1]);
            //}

            //else if (score == 3)
            //{
            //    crystalPlaySource.PlayOneShot(crystalPickup[2]);
            //}

            //else if (score == 4)
            //{
            //    crystalPlaySource.PlayOneShot(crystalPickup[3]);
            //}

            //else if (score == 5)
            //{
            //    crystalPlaySource.PlayOneShot(crystalPickup[4]);
            //}

            //else if (score == 6)
            //{
            //    crystalPlaySource.PlayOneShot(crystalPickup[5]);
            //}

            //else if (score == 7)
            //{
            //    crystalPlaySource.PlayOneShot(crystalPickup[6]);
            //}

            //else if (score == 8)
            //{
            //  crystalPlaySource.PlayOneShot(crystalPickup[7]);
            //}

            //else if (FireProgress.enoughFuel)
            //{
            //    crystalPlaySource.PlayOneShot(crystalPickup[7]);
            //}

            //else if (FireProgress.enoughFuel == false)
            //{
            //    score = 1;
            //}

        }
	}

}
