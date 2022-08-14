using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardWoodBlock : BlockBase
{
    #region Variables

    [Header("Block")]
    [SerializeField] private int _addedScore;

    #endregion


    protected override void TouchWithBall(Collision2D col)
    {
        HUD.Instance.IncrementScore(_addedScore);
        Destroy(gameObject);
    }
}