using UnityEngine;

class ScoreUpPickUp : PickUpBase
{
    #region Variables

    [Header(nameof(ScoreUpPickUp))]
    [SerializeField] private int _scoreToChange;

    #endregion


    #region Protected methods

    protected override void ApplyEffect(Collision2D col)
    {
        HUD.Instance.IncrementScore(_scoreToChange);
    }

    #endregion
}