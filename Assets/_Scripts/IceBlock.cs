using UnityEngine;

public class IceBlock : Block
{
    [SerializeField] int randomRange = 90;

    new void Start()
    {
        resistance = 2;
        base.Start();
    }


    protected override void BounceBall(Collision collision)
    {
        base.BounceBall(collision);

        if (collision.rigidbody != null)
        {
            Vector3 currentVelocity = collision.rigidbody.velocity;
            float randomAngle = Random.Range(-randomRange, randomRange);
            Quaternion rotation = Quaternion.AngleAxis(randomAngle, Vector3.forward);
            collision.rigidbody.velocity = rotation * currentVelocity;
        }
    }
}
