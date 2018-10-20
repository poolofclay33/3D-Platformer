using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    static float timer = 0.0f;
    static float bestTime = 0.0f;
    public TMP_Text _txt;
    public TMP_Text _bestTimeTxt;

    private void Update()
    {
        timer += Time.deltaTime;
        _txt.text = timer.ToString("0:00.00");

        if(timer > bestTime)
        {
            _bestTimeTxt = _txt;
        }
    }
}
