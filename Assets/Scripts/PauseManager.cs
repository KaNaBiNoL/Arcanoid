using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseManager : SingletonMonoBehaviour<PauseManager>
{
    #region Variables

    [SerializeField] private GameObject _pausePanel;

    [SerializeField] private Button ContinueButton;
    [SerializeField] private Button RestartButton;
    [SerializeField] private Button ExitButton;

    public bool _isPaused;

    #endregion


    #region Unity lifecycle

    private void Start()
    {
        ContinueButton.onClick.AddListener(ContinueButtonClicked);
        RestartButton.onClick.AddListener(RestartButtonClicked);
        ExitButton.onClick.AddListener(ExitButtonClicked);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _pausePanel.activeSelf == false)
        {
            TogglePause();
            _pausePanel.SetActive(true);
            
        }
    }

    #endregion


    #region Public methods

    public void TogglePause()
    {
        
        _isPaused = !_isPaused;
        Time.timeScale = _isPaused ? 0 : 1;
    }

    #endregion


    #region Private methods

    private void RestartButtonClicked()
    {

        SceneManager.LoadScene(0);
        _pausePanel.SetActive(false);
    }

    private void ContinueButtonClicked()
    {
        TogglePause();
        _pausePanel.SetActive(false);
    }

    private void ExitButtonClicked()
    {
        Application.Quit();
    }

    #endregion
}