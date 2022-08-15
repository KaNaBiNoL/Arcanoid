using UnityEngine;

class PadWidthUpPickUp : PickUpBase
{
    [Header(nameof(PadWidthUpPickUp))]
    [SerializeField] private float _scaleMultiplier;
    
    protected override void ApplyEffect(Collision2D col)
    {
        FindObjectOfType<Pad>().ChangeWidth(_scaleMultiplier);
    }
}