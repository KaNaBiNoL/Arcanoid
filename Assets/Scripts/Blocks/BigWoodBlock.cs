using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigWoodBlock : BlockBase
{
    #region Variables

    [SerializeField] private Sprite _damagedHp;
    private SpriteRenderer image;
    private int _hp = 2;

    #endregion


    #region Unity lifecycle

    private void Start()
    {
        image = gameObject.GetComponent<SpriteRenderer>();
    }

    #endregion


    protected override void TouchWithBall(Collision2D col)
    {
        if (_hp == 2)
        {
            _hp = 1;

            image.sprite = _damagedHp;
        }

        else if (_hp == 1)
        {
            Destroy(gameObject);
            GUI.Instance.IncrementScore(300);
        }
    }
}