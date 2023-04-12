using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    private bool _endGame = false;
    private GameManager _gameManager;
    private Player _player;

    [SerializeField] public TMP_Text scoreTxt = default;
    [SerializeField] public TMP_Text timeTxt = default;
    [SerializeField] public TMP_Text finalTxt = default;

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

            if (sceneNbr == 1 || sceneNbr == 2)
            {
                SceneManager.LoadScene(sceneNbr + 1);                 
            }
            
            if (sceneNbr == 3)
            {
                _player.EndGamePlayer();
                _endGame = true;

                SceneManager.LoadScene(sceneNbr + 1);

                int score = _gameManager.GetScore();
                double time = _gameManager.GetTime();
                double finalScore = time + score;

                scoreTxt.text = "Pénalités : " + score.ToString();
                timeTxt.text = "Temps total : " + time.ToString();
                finalTxt.text = finalScore.ToString();
            }
        }
    }
}
