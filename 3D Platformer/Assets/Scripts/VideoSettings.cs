using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoSettings : MonoBehaviour {

    public GameObject _cube;
    public Material _cubeHighlight;
    public Material _cubeColor;
    public Material _cubeClicked;
    public GameObject _soundCube;

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
        _soundCube.SetActive(false);
        //_soundCube.transform.position = new Vector3(-435.88f, -182.86f, -13.04f);
        //_soundCube.transform.rotation = Quaternion.Euler(1.222f, -35.784f, 1.695f);
        _cube.gameObject.SetActive(true);
        _cube.GetComponent<Rigidbody>().AddForce(0, _downSpeed, 0, ForceMode.Impulse);
        yield return new WaitForSeconds(.1f);
    }
}
