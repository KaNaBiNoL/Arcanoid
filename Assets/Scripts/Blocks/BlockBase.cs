using System;
using UnityEngine;
using Random = UnityEngine.Random;

public abstract class BlockBase : MonoBehaviour
{
    #region Variables

    [Header("PickUp")]
    [SerializeField] private GameObject _pickUpPrefab;
    [Range(0f, 1f)]
    [SerializeField] private float _spawnChance;

    #endregion


    #region Events

    public event Action<BlockBase> OnDestroyed;

    #endregion


    #region Unity lifecycle

    private void OnCollisionEnter2D(Collision2D col)
    {
        TouchWithBall(col);
        SpawnPickUp();
    }

    #endregion


    #region Private methods

    private void SpawnPickUp()
    {
        float range = Random.Range(0f, 1f);
        if (range < _spawnChance)
        {
            Instantiate(_pickUpPrefab, transform.position, Quaternion.identity);
        }
    }

    private void OnDestroy()
    {
        OnDestroyed?.Invoke(this);
    }

    #endregion


    #region Protected methods

    protected abstract void TouchWithBall(Collision2D col);

    #endregion
}