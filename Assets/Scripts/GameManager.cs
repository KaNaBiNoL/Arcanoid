using TMPro;
using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    #region Variables

    [SerializeField] private Ball _ball;
    [SerializeField] private GameObject _winPanel;
    [SerializeField] private TextMeshProUGUI _levelScoreLabel;
    
    private bool _isStarted = false;

    #endregion


    #region Unity lifecycle

    private void Update()
    {
        if (_isStarted)
        {
            return;
        }

        _ball.MoveWithPad();

        if (Input.GetMouseButtonDown(0))
        {
            StartBall();
            _ball.StartMove();
        }
    }

    #endregion


    #region Private methods

    private void StartBall()
    {
        _isStarted = true;
    }

    #endregion


    public void PerformWin()
    {
        PauseManager.Instance.TogglePause();
        _winPanel.SetActive(true);
        _levelScoreLabel.text = $"Your Score:{GUI.Instance.Score}";
    }
}