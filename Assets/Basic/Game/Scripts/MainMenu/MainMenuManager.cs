using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private string _gameplaySceneName;

    public void Play()
    {
        SceneManager.LoadScene(_gameplaySceneName);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
