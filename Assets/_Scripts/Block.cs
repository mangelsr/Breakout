using UnityEngine;
using UnityEngine.Events;

public class Block : MonoBehaviour
{
    [SerializeField] protected int resistance = 1;

    public UnityEvent increaseScore;

    protected void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            BounceBall(collision);
        }
    }

    void Update()
    {
        if (resistance <= 0)
        {
            increaseScore.Invoke();
            Destroy(gameObject);
        }
    }

    protected virtual void BounceBall(Collision collision)
    {
        Vector3 direction = collision.contacts[0].point - transform.position;
        direction = direction.normalized;
        collision.rigidbody.velocity = collision.gameObject.GetComponent<Ball>().settings.ballSpeed * direction;
        resistance--;
    }
}
