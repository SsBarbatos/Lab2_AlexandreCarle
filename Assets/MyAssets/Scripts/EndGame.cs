using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    private bool _endGame = false;
    private GameManager _gameManager;
    private Player _player;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        if (_endGame == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Application.Quit();
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && _endGame == false)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            // Recuperer l'index de la scene
            int sceneNbr = SceneManager.GetActiveScene().buildIndex;

            if (sceneNbr == 0)
            {
                SceneManager.LoadScene(sceneNbr + 1);
            }
            else
            {
                int score = _gameManager.GetScore();
                float finalScore = Time.time + score;
                _player.EndGamePlayer();

                Debug.Log("Fin de partie!");
                Debug.Log("Le temps est de " + Time.time + "sec");
                Debug.Log("Vous avez accroché " + score + " obstacles...");
                Debug.Log("Votre score final est de " + finalScore + "sec");

                _endGame = true;
            }

        }
    }
}
