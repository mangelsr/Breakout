using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBlock : Block
{
    [SerializeField] int randomRange = 15;

    void Start()
    {
        resistance = 2;
    }

    void Update()
    {

    }

    protected override void BounceBall(Collision collision)
    {
        base.BounceBall(collision);
        // Bounce on an random angle; calculated bounce +/- randomRange
    }
}
