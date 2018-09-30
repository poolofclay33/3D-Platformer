using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    public GameObject _play;
    public GameObject _settings;
    public GameObject _exit;
	
	public void Play()
    {
        Debug.Log("Clicked");
    }

    public void Settings()
    {
        Debug.Log("Clicked(2)");
    }

	public void Exit()
	{
        Debug.Log("Clicked(3)");
	}
}
