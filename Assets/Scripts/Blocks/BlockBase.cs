using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public abstract class BlockBase : MonoBehaviour
{
    
    #region Unity lifecycle

    private void Awake()
    {
        
    }

    #endregion
    #region Unity lifecycle

    private void OnCollisionEnter2D(Collision2D col)
    {
        TouchWithBall(col);
    }

    #endregion


    #region Protected methods

    protected abstract void TouchWithBall(Collision2D col);


    #endregion
}
