using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{
    public int _scenenumber;
    public void LoadScene()
    {
        SceneManager.LoadScene(_scenenumber);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
