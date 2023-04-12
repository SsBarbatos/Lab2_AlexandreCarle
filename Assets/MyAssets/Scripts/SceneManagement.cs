using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    private bool onRules = false;
    [SerializeField] private GameObject ruleMenu = default;

    public void Quit()
    {
        Application.Quit();
    }

    public void ChangeScene()
    {
        int sceneNbr = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneNbr + 1);
    }

    public void ChargeFirstScene()
    {
        SceneManager.LoadScene(0);
    }

    public void RulesManager()
    {
        if (onRules == false)
        {
            ruleMenu.SetActive(true);
            onRules = true;
        }
        else
        {
            ruleMenu.SetActive(false);
            onRules = false;
        }
    }
}
