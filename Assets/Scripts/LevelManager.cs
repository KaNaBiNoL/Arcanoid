using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : SingletonMonoBehaviour<LevelManager>
{
    #region Variables

    [SerializeField] private GameObject _borders;
    [SerializeField] private GameObject _bottomBorder;
    

    #endregion


    #region Unity lifecycle

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(_borders);
    }

    private void Update()
    {
        BlockBase[] blocks = FindObjectsOfType<BlockBase>();
        if (blocks.Length == 0)
        {
            Debug.Log("Win");
        }
    }

    #endregion
}
