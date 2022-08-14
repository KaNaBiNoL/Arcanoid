using UnityEngine;

class SpeedDownPickUp : PickUpBase
{
    [Header(nameof(SpeedDownPickUp))]
    [SerializeField] private float speedMultiplier;
    protected override void ApplyEffect(Collision2D col)
    {
        FindObjectOfType<Ball>().ChangeSpeed(speedMultiplier);
    }
}
