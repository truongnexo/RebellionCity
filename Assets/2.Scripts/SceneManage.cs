using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("RebellionCity");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");

    }
    public void Guide()
    {
        SceneManager.LoadScene("Guide");
    }

    public void Store()
    {
        SceneManager.LoadScene("Store");
    }

}
