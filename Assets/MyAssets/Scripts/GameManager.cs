using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // ATTRIBUTS
    private int _score;

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
        _score = 0;
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
        _score++;
        Debug.Log("Nombre de collision : " + _score);
    }

    public int GetScore()
    {
        return _score;
    }
}
