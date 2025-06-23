using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodBlock : Block
{
    void Start()
    {
        resistance = 2;
    }

    void Update()
    {

    }

    protected override void BounceBall()
    {
        base.BounceBall();
    }
}
