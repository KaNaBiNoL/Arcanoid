using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Variables

    [SerializeField] private Ball _ball;
    
    private bool _isStarted = false;
    
    #endregion


    #region  Unity lifecycle

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
    
    
}
