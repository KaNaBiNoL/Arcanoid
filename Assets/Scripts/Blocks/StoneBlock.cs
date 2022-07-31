using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneBlock : BlockBase
{
    #region Variables

    
    [SerializeField] private Sprite _middleHpSprite;
    [SerializeField] private Sprite _lowHpSprite;
    private int _hp = 3;
    private SpriteRenderer image;
    #endregion


    private void Start()
    {
        image = gameObject.GetComponent<SpriteRenderer>();
    }


    #region Protected methods

    protected override void TouchWithBall(Collision2D col)
    {
        
        switch (_hp)
        {
            case 3:
                TakeDamage(_middleHpSprite);
                break;
            case 2:
                TakeDamage(_lowHpSprite);
                break;
            case 1:
                Destroy(gameObject);
                break;

        }
            
            
    }

    #endregion


    #region Private methods

    private void TakeDamage(Sprite sprite)
    {
         image.sprite = sprite;
        _hp--;
    }

    #endregion
}
