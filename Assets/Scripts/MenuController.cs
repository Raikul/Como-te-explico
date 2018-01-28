using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {


    public static MenuController Instance;

    void Awake()
    {
        Instance = this;
    }


    public void LoadScene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
