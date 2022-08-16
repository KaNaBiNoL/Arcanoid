using UnityEngine;

public class BigWoodBlock : BlockBase
{
    #region Variables

    [Header("Block")]
    [SerializeField] private int _addedScore;

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


    #region Protected methods

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
            HUD.Instance.IncrementScore(_addedScore);
        }
    }

    #endregion
}