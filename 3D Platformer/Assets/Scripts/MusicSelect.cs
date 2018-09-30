using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSelect : MonoBehaviour {

    public AudioSource _audio;
    public AudioClip _dance;
    public AudioClip _country;

    public void dance()
    {
        Debug.Log("!!!");
        _audio.clip = _dance;
        _audio.Play();
    }

    public void country()
    {
        _audio.clip = _country;
        _audio.Play();
    }
}
