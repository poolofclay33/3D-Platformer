using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSlider : MonoBehaviour {

    public AudioSource _audio;
	
	// Update is called once per frame
	public void musicVolume(float vol) 
    {
        _audio.volume = vol;
	}
}
