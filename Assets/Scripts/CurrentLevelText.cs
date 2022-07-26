using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentLevelText : MonoBehaviour
{
    public Text CurrentLevel;
    public Game Game;
    void Start()
    {
        CurrentLevel.text = "Level " + (Game.LevelIndex + 1).ToString();
    }
}
