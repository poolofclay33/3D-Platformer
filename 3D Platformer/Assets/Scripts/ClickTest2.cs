using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTest2 : MonoBehaviour {

    public Material _cubeHighlight;
    public Material _cubeColor;
    public Material _cubeClicked;
    public Animator _camAnim;
    public GameObject _cube4;
    public GameObject _cube5;
    public GameObject _cube6;
    public GameObject _cube7;

	private void OnMouseDown()
    {
        GetComponent<Renderer>().material = _cubeClicked;
        StartCoroutine("Settings");
    }

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material = _cubeHighlight;
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material = _cubeColor;
    }

    IEnumerator Settings()
    {
        _camAnim.Play("Settings_Cam");
        yield return new WaitForSeconds(.2f);
        _cube4.GetComponent<Rigidbody>().isKinematic = false;
        _cube5.GetComponent<Rigidbody>().isKinematic = false;
        _cube6.GetComponent<Rigidbody>().isKinematic = false;
        _cube7.GetComponent<Rigidbody>().isKinematic = false;
    }
}
