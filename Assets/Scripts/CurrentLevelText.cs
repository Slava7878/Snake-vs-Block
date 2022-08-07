using UnityEngine;
using TMPro;

public class CurrentLevelText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _currentLevel;
    [SerializeField] private Game _game;

    void Start()
    {
        _currentLevel.text = (_game.LevelIndex + 1).ToString();
    }
}
