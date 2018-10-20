using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryPickup : MonoBehaviour {

    public Image _battery;

	public void Start()
	{
        var tmpColor = _battery.color;
        tmpColor.a = .5f;
        _battery.color = tmpColor;
	}

	public void OnTriggerEnter(Collider other)
	{
        var fullColor = _battery.color;
        fullColor.a = 1f;

        if (other.tag == "Battery")
        {
            other.gameObject.SetActive(false);
            _battery.color = fullColor;
            Debug.Log(":)");
        }
	}
}