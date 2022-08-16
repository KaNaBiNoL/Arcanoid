using UnityEngine;

public abstract class PickUpBase : MonoBehaviour
{
    #region Unity lifecycle

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag(Tags.Pad))
        {
            ApplyEffect(col);
        }

        Destroy(gameObject);
    }

    #endregion


    #region Protected methods

    protected abstract void ApplyEffect(Collision2D col);

    #endregion
}