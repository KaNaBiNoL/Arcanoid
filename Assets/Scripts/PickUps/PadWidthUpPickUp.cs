using UnityEngine;

class PadWidthUpPickUp : PickUpBase
{
    #region Variables

    [Header(nameof(PadWidthUpPickUp))]
    [SerializeField] private float _scaleMultiplier;

    #endregion


    #region Protected methods

    protected override void ApplyEffect(Collision2D col)
    {
        FindObjectOfType<Pad>().ChangeWidth(_scaleMultiplier);
    }

    #endregion
}