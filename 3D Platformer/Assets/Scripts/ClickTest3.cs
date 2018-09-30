using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTest3 : MonoBehaviour {

    public Material _cubeHighlight;
    public Material _cubeColor;
    public Material _cubeClicked;

    private void OnMouseDown()
    {
        GetComponent<Renderer>().material = _cubeClicked;
        //quit option
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
