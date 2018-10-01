using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsBack : MonoBehaviour {

    public Material _cubeHighlight;
    public Material _cubeColor;
    public Material _cubeClicked;
    public Animator _animCam;

    private void OnMouseDown()
    {
        GetComponent<Renderer>().material = _cubeClicked;
        _animCam.Play("Credits_Back");
    }

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material = _cubeHighlight;
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material = _cubeColor;
    }
}
