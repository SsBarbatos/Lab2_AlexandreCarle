using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
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
}
