using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

    public GameManager _game;

	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Respawn")
        {
            _game.StartCoroutine("RespawnEffect");
        }

        if(other.tag == "Finish")
        {
            _game.Finish();
        }
	}

    /*
    IEnumerator RespawnEffect()
    {
        _death.Play();
        _player.SetActive(false);
        yield return new WaitForSeconds(3f);
        RespawnPlayer();
    }

    public void RespawnPlayer()
    {
        _player.SetActive(true);
        _player.transform.position = spawnPoint.transform.position;
        _respawn.Play();
    }
    */
}
