using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public Controls Controls;
    public GameObject LoseScreen;
    public GameObject WinScreen;
    public GameObject ControlButtons;
    public TailSpawner TailSpawner;

    public enum State
    {
        Playing,
        Won,
        Loss,
    }

    public State CurrentState { get; private set; }

    public void OnPlayerDied()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Loss;
        Controls.enabled = false;
        TailSpawner.enabled = false;
        Debug.Log("Game Over!");
        LoseScreen.SetActive(true);
        ControlButtons.SetActive(false);
    }

    public void OnPlayerReachedFinish()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Won;
        Controls.enabled = false;
        TailSpawner.enabled = false;
        LevelIndex++;
        Debug.Log("You won!");
        WinScreen.SetActive(true);
        ControlButtons.SetActive(false);
    }

    public int LevelIndex
    {
        get => PlayerPrefs.GetInt(LevelIndexKey, 0);
        private set
        {
            PlayerPrefs.SetInt(LevelIndexKey, value);
            PlayerPrefs.Save();
        }
    }

    private const string LevelIndexKey = "LevelIndex";

    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
