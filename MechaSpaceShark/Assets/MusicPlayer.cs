using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour {

    public AudioSource musicSource;
    public List<AudioClip> musicClips;
    private IEnumerator coroutine;
    public Toggle isToggle;
    public float length;

    public void Awake()
    {
        musicSource.PlayOneShot(musicClips[0]);
        length = musicClips[0].length;
        //length = length - .0f;

        musicSource.PlayDelayed(length);
    }

    public void Update()
    {
        if (Obstacle.CollideWithAsteroid)
        {
            musicSource.Stop();
        }
    }
}
