using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dance_Menu : MonoBehaviour {

    public Animator _anim;

	private void Awake()
	{
        _anim.Play("Dance");
	}
}
