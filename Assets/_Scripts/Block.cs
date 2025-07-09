using UnityEngine;
using UnityEngine.Events;

public class Block : MonoBehaviour
{
    [SerializeField] protected Settings settings;
    [SerializeField] protected int resistance = 1;

    public UnityEvent increaseScore;

    protected void Start()
    {
        switch (settings.levelDifficulty)
        {
            case Difficulty.Easy:
                resistance = resistance / 2;
                if (resistance == 0) resistance = 1;
                break;
            case Difficulty.Hard:
                resistance = resistance * 2;
                break;
        }
    }

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
