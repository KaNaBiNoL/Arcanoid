using UnityEngine;

class PadWidthDownPickUp : PickUpBase
{
    #region Variables

    [Header(nameof(PadWidthDownPickUp))]
    [SerializeField] private float _scaleMultiplier;

    #endregion


    #region Protected methods

    protected override void ApplyEffect(Collision2D col)
    {
        FindObjectOfType<Pad>().ChangeWidth(_scaleMultiplier);
    }

    #endregion
}