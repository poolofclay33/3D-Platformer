using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropdownScript : MonoBehaviour {

    public TMP_Dropdown dropdown;
    public AudioSource _audio;
    public AudioClip _dance;
    public AudioClip _country;
    public AudioClip _default;

    public void indexDropdown(int index)
    {
        if (index == 0)
        {
            Debug.Log("!");
            _audio.clip = _default;
            _audio.Play();
        }

        if(index == 1)
        {
            Debug.Log("!!");
            _audio.clip = _dance;
            _audio.Play(); 
        }

        if (index == 2)
        {
            Debug.Log("!!!");
            _audio.clip = _country;
            _audio.Play();
        }
    }
}
