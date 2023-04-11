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
        InstructionDepart();
        score = 0;
        time = Time.time;
    }

    void Update()
    {

    }

    public static void InstructionDepart()
    {
        Debug.Log("***  Past Present Futur  *********************************************************");
        Debug.Log("* Le but du jeu est de terminer les 3 niveaux le plus rapidement possible.       *");
        Debug.Log("* Chaque contact avec un mur ou un obstacle augmentera votre temps de 1 seconde. *");
        Debug.Log("**********************************************************************************");
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
