using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landing : MonoBehaviour {

    public Animator _anim;

    public void StartLanding()
    {
        _anim.Play("Landing");
    }
}
