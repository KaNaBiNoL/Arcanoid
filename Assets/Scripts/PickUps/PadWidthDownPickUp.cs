using UnityEngine;

class PadWidthDownPickUp : PickUpBase
{
    [Header(nameof(PadWidthDownPickUp))]
    [SerializeField] private float _scaleMultiplier;
    
    protected override void ApplyEffect(Collision2D col)
    {
        FindObjectOfType<Pad>().ChangeWidth(_scaleMultiplier);
    }
}