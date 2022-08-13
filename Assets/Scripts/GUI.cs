using TMPro;
using UnityEngine;

public class GUI : SingletonMonoBehaviour<GUI>
{
    [SerializeField] private TextMeshProUGUI _scoreLabel;
    public int Score { get; private set; }
    public int WholeScore { get; private set; }

    private int _playerHealth;


    public void IncrementScore(int score)
    {
        Score += score;
        _scoreLabel.text = $"Score: {Score}";
    }

}
