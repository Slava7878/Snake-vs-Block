using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    
    private int _currentScore;
    
    void Update()
    {
        _scoreText.text = "Score: " + _currentScore.ToString();
    }

    public void AddScore()
    {
        _currentScore++;
    }
}
