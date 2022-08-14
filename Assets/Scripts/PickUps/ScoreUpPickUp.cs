using UnityEngine;

class ScoreUpPickUp : PickUpBase
{
    [Header(nameof(ScoreUpPickUp))]
    [SerializeField] private int _scoreToChange;
    
    protected override void ApplyEffect(Collision2D col)
    {
        HUD.Instance.IncrementScore(_scoreToChange);
    }
}