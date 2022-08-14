using UnityEngine;

class SpeedUpPickUp : PickUpBase
{
    [Header(nameof(SpeedUpPickUp))]
    [SerializeField] private float speedMultiplier;
    protected override void ApplyEffect(Collision2D col)
    {
        FindObjectOfType<Ball>().ChangeSpeed(speedMultiplier);
    }
}