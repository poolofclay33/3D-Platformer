using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSettings : MonoBehaviour {

    public GameObject _cube;
    public Material _cubeHighlight;
    public Material _cubeColor;
    public Material _cubeClicked;

    private void OnMouseDown()
    {
        GetComponent<Renderer>().material = _cubeClicked;
        StartCoroutine("Clicked");
    }

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material = _cubeHighlight;
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material = _cubeColor;
    }

    public float _downSpeed;

    IEnumerator Clicked()
    {
        _cube.gameObject.SetActive(true);
        _cube.GetComponent<Rigidbody>().AddForce(0, _downSpeed, 0, ForceMode.Impulse);
        yield return new WaitForSeconds(.1f);
    }
}
