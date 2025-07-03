using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settingsMenu;
    public GameObject startMenu;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void EndGame()
    {
        Application.Quit();
    }

    public void ShowSettings()
    {
        startMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void ShowStart()
    {
        settingsMenu.SetActive(false);
        startMenu.SetActive(true);
    }
}
