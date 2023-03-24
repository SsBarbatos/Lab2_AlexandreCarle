using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionsManager : MonoBehaviour
{
    // ATTRIBUTS
    private GameManager _gameManager;
    [SerializeField] private List<GameObject> _ListGameObjects = new List<GameObject>();
    [SerializeField] private List<MeshRenderer> _ListMesh = new List<MeshRenderer>();
    private bool _touch;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _touch = false;

        foreach(var gameObject in _ListGameObjects)
        {
            _ListMesh.Add(gameObject.GetComponent<MeshRenderer>());
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (_touch == false)
            {
                foreach (var gameObject in _ListMesh)
                {
                    gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                
                _gameManager.ScoreIncreasing();

                _touch = true;
            }
        }
    }
}
