using System;
using UnityEngine;

public abstract class PickUpBase : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        ApplyEffect(col);
        Destroy(gameObject);
    }

    protected abstract void ApplyEffect(Collision2D col);

}