using UnityEngine;

class SpeedDownPickUp : PickUpBase
{
    #region Variables

    [Header(nameof(SpeedDownPickUp))]
    [SerializeField] private float speedMultiplier;

    #endregion


    #region Protected methods

    protected override void ApplyEffect(Collision2D col)
    {
        FindObjectOfType<Ball>().ChangeSpeed(speedMultiplier);
    }

    #endregion
}