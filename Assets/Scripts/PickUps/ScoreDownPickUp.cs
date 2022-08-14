using Unity.VisualScripting;
using UnityEngine;

class ScoreDownPickUp : PickUpBase
{
    [Header(nameof(ScoreDownPickUp))]
    [SerializeField] private int _scoreToChange;
    
    protected override void ApplyEffect(Collision2D col)
    {
        HUD.Instance.IncrementScore(_scoreToChange);
    }
}