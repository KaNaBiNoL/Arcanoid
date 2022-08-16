using UnityEngine;

public class StandardWoodBlock : BlockBase
{
    #region Variables

    [Header("Block")]
    [SerializeField] private int _addedScore;

    #endregion


    #region Protected methods

    protected override void TouchWithBall(Collision2D col)
    {
        HUD.Instance.IncrementScore(_addedScore);
        Destroy(gameObject);
    }

    #endregion
}