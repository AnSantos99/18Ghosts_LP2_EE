using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /// <summary>
    /// Loads the actual game scene
    /// </summary>
    public void StartGame() 
    {
        SceneManager.LoadScene("Game");
    }

    public void Instructions() 
    {

    }

    /// <summary>
    /// Quit the application
    /// </summary>
    public void QuitGame()
    {
        // For Testing
        //UnityEditor.EditorApplication.isPlaying = false;

        Application.Quit();
    }
}
