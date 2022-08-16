using UnityEngine;

class InvisibleBlock : BlockBase
{
    #region Variables

    [Header("Block")]
    [SerializeField] private int _addedScore;

    private SpriteRenderer image;
    private int _hp = 2;

    #endregion


    #region Unity lifecycle

    private void Start()
    {
        image = gameObject.GetComponent<SpriteRenderer>();
        SetAlpha(0);
    }

    #endregion


    #region Protected methods

    protected override void TouchWithBall(Collision2D col)
    {
        switch (_hp)
        {
            case 2:
                SetAlpha(255);
                _hp--;
                break;
            case 1:
                HUD.Instance.IncrementScore(_addedScore);
                Destroy(gameObject);
                break;
        }
    }

    #endregion


    #region Private methods

    private void SetAlpha(int alpha)
    {
        Color imageColor = image.color;
        imageColor.a = alpha;
        image.color = imageColor;
    }

    #endregion
}