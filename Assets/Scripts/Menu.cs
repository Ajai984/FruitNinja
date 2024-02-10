using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string mainGameScene;

    // Start is called before the first frame update
    void StartGame()
    {
        SceneManager.LoadScene(mainGameScene);

    }

    // Update is called once per frame
    void QuitGame()
    {
        Application.Quit();
    }
}
