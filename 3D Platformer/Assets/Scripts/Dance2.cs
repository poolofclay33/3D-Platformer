using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dance2 : MonoBehaviour {

    public Animator _anim;

    private void Awake()
    {
        _anim.Play("Dance2");
    }
}
