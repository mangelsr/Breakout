using UnityEngine;

public class WoodBlock : Block
{
    new void Start()
    {
        resistance = 2;
        base.Start();
    }

    protected override void BounceBall(Collision collision)
    {
        base.BounceBall(collision);
    }
}
