using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    #region Variables

    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private Vector2 _startDirection;
    [SerializeField] private Pad _pad;

    private Vector3 _startPosition;
    private bool _isStarted;
    #endregion


    #region Unity lifecycle

    private void Awake()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        if ( (_isStarted))
        {
            return;
        }
        
        MoveWithPad();
        
        if (Input.GetMouseButtonDown(0))
        {
            StartBall();
        }
    }

    #endregion
    #region Public methods

    public void MoveWithPad()
    {
        Vector3 padPosition = _pad.transform.position;
        Vector3 currentPosition = transform.position;
        currentPosition.x = padPosition.x;
        transform.position = currentPosition;
    }

    public void StartMove()
    {
        _rb.velocity = _startDirection;
    }

    public void ToDefaultState()
    {
        _isStarted = false;
        _rb.velocity = Vector2.zero;
        transform.position = _startPosition;
    }

    #endregion


    #region Private methods

    private void StartBall()
    {
        _isStarted = true;
        StartMove();
    }

    #endregion
}