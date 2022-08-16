using UnityEngine;

class SpeedUpPickUp : PickUpBase
{
    #region Variables

    [Header(nameof(SpeedUpPickUp))]
    [SerializeField] private float speedMultiplier;

    #endregion


    #region Protected methods

    protected override void ApplyEffect(Collision2D col)
    {
        FindObjectOfType<Ball>().ChangeSpeed(speedMultiplier);
    }

    #endregion
}