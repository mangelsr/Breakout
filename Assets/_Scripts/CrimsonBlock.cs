using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrimsonBlock : Block
{
    [SerializeField] int percentageToReduce = 5;

    void Start()
    {
        resistance = 1;
    }

    void Update()
    {

    }

    protected override void BounceBall(Collision collision)
    {
        base.BounceBall(collision);
        // Reduce points by percentageToReduce
    }
}
