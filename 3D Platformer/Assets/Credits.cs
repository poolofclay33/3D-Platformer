using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour {

    public Material _cubeHighlight;
    public Material _cubeColor;
    public Material _cubeClicked;
    public Animator _animCam;
    public GameObject _creditsCube;
    public GameObject _backCube;

    private void OnMouseDown()
    {
        GetComponent<Renderer>().material = _cubeClicked;
        _animCam.Play("Credits_Cam");
        _creditsCube.SetActive(true);
        _backCube.SetActive(true);
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
