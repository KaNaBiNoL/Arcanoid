using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    #region Variables

    [Header("Ball")]
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _normalBallSpeed;
    [SerializeField] private float _minSpeed;
    [SerializeField] private float _maxSpeed;
    [SerializeField] private float _xMaxDirection;
    [SerializeField] private float _xMinDirection;
    [SerializeField] private float _yMaxDirection;
    [SerializeField] private float _yMinDirection;

    [SerializeField] private Pad _pad;

    private Vector3 _startPosition;
    private bool _isStarted;
    private Vector2 _startDirection;

    #endregion


    #region Unity lifecycle

    private void Awake()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        if ((_isStarted))
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
        _rb.velocity = GetRandomDirection();
    }

    public void ToDefaultState()
    {
        _isStarted = false;
        _rb.velocity = Vector2.zero;
        transform.position = _startPosition;
    }

    public void ChangeSpeed(float speedMultiplier)
    {
        Vector2 velocity = _rb.velocity;
        float velocityMagnitude = velocity.magnitude;
        velocityMagnitude *= speedMultiplier;

        if (velocityMagnitude < _minSpeed)
        {
            velocityMagnitude = _minSpeed;
        }
        if (velocityMagnitude > _maxSpeed)
        {
            velocityMagnitude = _maxSpeed;
        }

        _rb.velocity = velocity.normalized * velocityMagnitude;
    }

    #endregion


    #region Private methods

    private void StartBall()
    {
        _isStarted = true;
        StartMove();
    }

    private Vector2 GetRandomDirection()
    {
        Vector2 randomDirection = new Vector2(Random.Range(_xMinDirection, _xMaxDirection),
            Random.Range(_yMinDirection, _yMaxDirection));
        _startDirection = randomDirection.normalized;
        _startDirection *= _normalBallSpeed;
        return _startDirection;
    }

    #endregion
}