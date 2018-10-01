using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour {

    public Material _cubeHighlight;
    public Material _cubeColor;
    public Material _cubeClicked;

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
        SceneManager.LoadScene("Testing");
        yield return new WaitForSeconds(.6f);
        //SceneManager.LoadScene("Testing");
    }
}
