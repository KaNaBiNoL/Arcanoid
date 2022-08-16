using TMPro;
using UnityEngine;

public class HUD : SingletonMonoBehaviour<HUD>
{
    #region Variables

    [SerializeField] private TextMeshProUGUI _scoreLabel;
    public int Score { get; private set; }
    public int WholeScore { get; private set; }

    #endregion


    #region Public methods

    public void IncrementScore(int score)
    {
        Score += score;
        _scoreLabel.text = $"Score: {Score}";
    }

    #endregion
}