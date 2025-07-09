using UnityEngine;

public class StoneBlock : Block
{
    new void Start()
    {
        resistance = 5;
        base.Start();
    }

    protected override void BounceBall(Collision collision)
    {
        base.BounceBall(collision);
    }
}
