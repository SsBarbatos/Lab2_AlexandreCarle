using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropZone : MonoBehaviour
{
    // ATTRIBUTS
    private GameManager _gameManager;
    private Player _player;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _player = FindObjectOfType<Player>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _player.transform.position = new Vector3(23.45f, 10.287f, 79.08f);
            _gameManager.ScoreIncreasing();
        }
    }
}
