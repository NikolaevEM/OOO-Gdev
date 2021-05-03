using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Continue;

    public string sceneToLoad = "Game";

    public void LoadGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ContinueButton()
    {
        MainMenu.SetActive(false);
        Continue.SetActive(true);
    }
    public void ExitMenuButton()
    {
        MainMenu.SetActive(true);
        Continue.SetActive(false);
    }
}
