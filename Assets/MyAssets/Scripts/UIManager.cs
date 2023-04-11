using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // [SerializeField] private Text scoreTxt = default; Text legacy
    [SerializeField] public TMP_Text scoreTxt = default; // TextMesh pro
    [SerializeField] public TMP_Text timeTxt = default;
    [SerializeField] private GameObject pauseMenu = default;

    private bool onPause = false;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        scoreTxt.text = "Penalties : " + gameManager.GetScore().ToString();

        Time.timeScale = 1;

        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        double time = Time.time - gameManager.GetTime();
        timeTxt.text = "Time : " + time.ToString("f2");
        PauseManager();
    }

    public void PauseManager()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && onPause == false)
        {
            pauseMenu.SetActive(true);
            onPause = true;

            Time.timeScale = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && onPause == true)
        {
            RemovePause();
        }
    }

    public void RemovePause()
    {
        pauseMenu.SetActive(false);
        onPause = false;

        Time.timeScale = 1;
    }

    public void ScoreIncreasing(int score)
    {
        scoreTxt.text = "Penalties : " + score.ToString();
    }
}
