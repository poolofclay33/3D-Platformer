using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaisePlatform : MonoBehaviour {

    public GameObject _platform;

	private void OnTriggerEnter(Collider other)
	{
        _platform.GetComponent<Animator>().Play("Test");
	}
}
