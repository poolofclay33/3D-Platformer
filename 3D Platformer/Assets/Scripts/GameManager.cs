using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour {

    public GameObject spawnPoint;
    public ParticleSystem _death;
    public ParticleSystem _respawn;
    public GameObject _player;
    GameManager _game;
    public Animator _playerAnim;
    public Transform _lookAt;
    public Animator _camAnim;
    public GameObject _camera;
    public GameObject _animCam;
    public GameObject _go;

    public GameObject _timerUI;
    public GameObject _batteryUI;
    public GameObject _levelUI;

    public GameObject _finishPanel;
    public GameObject _timeCompleted;
    public GameObject _bestTime;

	public  void Awake()
	{
        StartCoroutine("camAnim");
        //_camAnim.Play("Level_Start_Cam");
	}

    IEnumerator camAnim()
    {
        _camAnim.Play("Level_Start_Cam");
        yield return new WaitForSeconds(8.5f);
        _camera.SetActive(true);
        _animCam.SetActive(false);
    }

    IEnumerator GO()
    {
        yield return new WaitForSeconds(1);
        _go.SetActive(false);
        //_timerUI.GetComponent<Timer>().enabled = true;
        _player.GetComponent<MovementTest>().enabled = true;
        _player.GetComponent<Jumping>().enabled = true;
    }

	IEnumerator RespawnEffect()
    {
        _death.Play();
        _player.SetActive(false);
        yield return new WaitForSeconds(3f);
        RespawnPlayer();
    }

    public void RespawnPlayer()
    {
        _player.transform.position = spawnPoint.transform.position;
        _respawn.Play();
        StartCoroutine("Wait");
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        _player.SetActive(true);
        _playerAnim.Play("Running");
        _player.transform.LookAt(_lookAt);
    }

    public void Finish()
    {
        _finishPanel.SetActive(true);
        _player.GetComponent<MovementTest>().enabled = false;
        _player.GetComponent<Jumping>().enabled = false;

        _playerAnim.Play("Dance");

        _timeCompleted.GetComponent<TMP_Text>().text = _timerUI.GetComponent<TMP_Text>().text;

        _bestTime.GetComponent<TMP_Text>().text = _timerUI.GetComponent<TMP_Text>().text;
    }
}
