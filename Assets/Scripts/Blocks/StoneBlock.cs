using UnityEngine;

public class StoneBlock : BlockBase
{
    #region Variables

    [Header("Block")]
    [SerializeField] private int _addedScore;

    [SerializeField] private Sprite _middleHpSprite;
    [SerializeField] private Sprite _lowHpSprite;
    private int _hp = 3;
    private SpriteRenderer image;

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
                HUD.Instance.IncrementScore(_addedScore);
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