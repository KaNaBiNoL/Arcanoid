using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardWoodBlock : BlockBase
{
    protected override void TouchWithBall(Collision2D col)
    {
        Destroy(gameObject);
    }
}
