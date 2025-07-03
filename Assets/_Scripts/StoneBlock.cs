using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneBlock : Block
{
    void Start()
    {
        resistance = 5;
    }

    void Update()
    {

    }

    protected override void BounceBall(Collision collision)
    {
        base.BounceBall(collision);
    }
}
