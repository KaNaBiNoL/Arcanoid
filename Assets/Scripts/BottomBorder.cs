using UnityEngine;

public class BottomBorder : MonoBehaviour
{
    #region Unity lifecycle

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag(Tags.Ball))
        {
            GameManager.Instance.LoseLife();
        }
        else
        {
            Destroy(col.gameObject);
        }
    }

    #endregion
}