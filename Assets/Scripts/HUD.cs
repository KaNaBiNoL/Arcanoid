using TMPro;
using UnityEngine;

public class HUD : SingletonMonoBehaviour<HUD>
{
    [SerializeField] private TextMeshProUGUI _scoreLabel;
    public int Score { get; private set; }
    public int WholeScore { get; private set; }


    public void IncrementScore(int score)
    {
        Score += score;
        _scoreLabel.text = $"Score: {Score}";
    }

}
