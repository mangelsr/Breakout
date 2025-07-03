using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject settingsMenu;

    public void ShowPauseMenu()
    {
        pauseMenu.SetActive(true);
        if (settingsMenu.activeInHierarchy) settingsMenu.SetActive(false);
    }

    public void HidePauseMenu()
    {
        pauseMenu.SetActive(false);
    }

    public void NavigateToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ShowSettingsMenu()
    {
        pauseMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }
}
