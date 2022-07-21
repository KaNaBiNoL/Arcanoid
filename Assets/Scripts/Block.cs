using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Block : MonoBehaviour
{
    
    #region Unity lifecycle

    private void Awake()
    {
        
    }

    #endregion
    #region Unity lifecycle

    private void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(gameObject);
    }

    #endregion
}
