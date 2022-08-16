using TMPro;
using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    #region Variables

    [SerializeField] private GameObject _winPanel;
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private TextMeshProUGUI _winLevelScoreLabel;
    [SerializeField] private TextMeshProUGUI _loseLevelScoreLabel;

    public int _playerHealth = 3;

    #endregion


    #region Public methods

    public void PerformWin()
    {
        if ((_winPanel != null))
        {
            PauseManager.Instance.TogglePause();
            _winPanel.SetActive(true);
            _winLevelScoreLabel.text = $"Your Score:{HUD.Instance.Score}";
        }
    }

    public void PerformLose()
    {
        PauseManager.Instance.TogglePause();
        _losePanel.SetActive(true);
        _loseLevelScoreLabel.text = $"Your Score:{HUD.Instance.Score}";
    }

    public void LoseLife()
    {
        _playerHealth--;
        HealthBarController.Instance.SwitchHealthImage();
        FindObjectOfType<Ball>().ToDefaultState();

        if (_playerHealth == 0)
        {
            PerformLose();
        }
    }

    #endregion
}