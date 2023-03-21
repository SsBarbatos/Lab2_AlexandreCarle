using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionsManager : MonoBehaviour
{
    // ATTRIBUTS
    private GameManager _gameManager;
    private bool _touch;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _touch = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (_touch == false)
            {
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                _gameManager.ScoreIncreasing();
                _touch = true;
            }
        }
    }
}
