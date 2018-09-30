using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterVolume : MonoBehaviour {

    public void masterVol(float vol)
    {
        AudioListener.volume = vol;
    }
}
