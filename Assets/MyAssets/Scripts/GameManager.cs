using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // ATTRIBUTS
    private int score;
    private double time;

    // METHODES PRIVEES
    private void Awake()
    {
        int managerNbr = FindObjectsOfType<GameManager>().Length;

        if (managerNbr > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        score = 0;
        time = Time.time;
    }

    // METHODES PUBLIQUES
    public void ScoreIncreasing()
    {
        score++;
        UIManager uiManager = FindObjectOfType<UIManager>();
        uiManager.ScoreIncreasing(score);
    }

    public int GetScore()
    {
        return score;
    }

    public double GetTime()
    { 
        return time;
    }
}
