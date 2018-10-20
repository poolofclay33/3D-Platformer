using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartLevelAnim : MonoBehaviour {

    public Animator _playerAnim;
    public GameObject _actualPlayer;
    private int timer = 3;
    public TMP_Text _GO;
    public TMP_Text _countdownText;
    public GameObject _go;
    public GameManager _gm;

	private void Start()
	{
        _actualPlayer.GetComponent<MovementTest>().enabled = false;
        _actualPlayer.GetComponent<Jumping>().enabled = false;
	}

	void StartLanding()
    {
        _actualPlayer.SetActive(true);
        _playerAnim.Play("Landing");
    }

    IEnumerator Countdown()
    {
        _countdownText.enabled = true;

        while(timer >= 1)
        {
            yield return new WaitForSeconds(1);
            _countdownText.text = ("" + --timer);
        }
        _countdownText.enabled = false;
        _GO.enabled = true;
        _gm.StartCoroutine("GO");
    }
}
