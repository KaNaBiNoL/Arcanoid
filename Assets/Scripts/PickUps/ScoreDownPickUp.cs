using UnityEngine;

class ScoreDownPickUp : PickUpBase
{
    #region Variables

    [Header(nameof(ScoreDownPickUp))]
    [SerializeField] private int _scoreToChange;

    #endregion


    #region Protected methods

    protected override void ApplyEffect(Collision2D col)
    {
        HUD.Instance.IncrementScore(_scoreToChange);
    }

    #endregion
}