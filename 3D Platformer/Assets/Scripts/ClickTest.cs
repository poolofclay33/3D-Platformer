using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickTest : MonoBehaviour {

    public Material _cubeHighlight;
    public Material _cubeColor;
    public Material _cubeClicked;
    public Animator _playerAnim;
    public Animator _animCam;

	private void OnMouseDown()
	{
        StartCoroutine("startGameAnim");
        GetComponent<Renderer>().material = _cubeClicked;
        //sound on click
	}

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material = _cubeHighlight;
        //sound when entered
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material = _cubeColor;
        //possible sound when exited
    }

    IEnumerator startGameAnim()
    {
        _playerAnim.Play("Turn_and_Run");
        yield return new WaitForSeconds(.6f);
        _animCam.Play("Play_Cam");
        //SceneManager.LoadScene("Testing");
    }
}
