using System;
using UnityEngine;

public class Pad : MonoBehaviour
{
    #region Variables

    [Header("Pad")]
    [SerializeField] private float _maxScale;
    [SerializeField] private float _minScale;

    #endregion


    #region Unity lifecycle

    private void Update()
    {
        if (PauseManager.Instance._isPaused == false)
        {
            Vector3 mousePositionInPixels = Input.mousePosition;
            Vector3 mousePositionInUnits = Camera.main.ScreenToWorldPoint(mousePositionInPixels);

            Vector3 currentPosition = transform.position;
            currentPosition.x = mousePositionInUnits.x;
            transform.position = currentPosition;
        }
    }

    #endregion


    public void ChangeWidth(float scaleMultiplier)
    {
        Vector3 transformLocalScale = transform.localScale;
        transformLocalScale.x *= scaleMultiplier;
       
        if (transformLocalScale.x > _maxScale)
        {
            transformLocalScale.x = _maxScale;
        }

        if (transformLocalScale.x < _minScale)
        {
            transformLocalScale.x = _minScale;
        }

        transform.localScale = transformLocalScale;
    }
}