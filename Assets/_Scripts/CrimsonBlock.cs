using UnityEngine;

public class CrimsonBlock : Block
{
    [SerializeField] int percentageToReduce = 5;

    new void Start()
    {
        resistance = 2;
        base.Start();
    }

    protected override void BounceBall(Collision collision)
    {
        base.BounceBall(collision);
        Score score = Camera.main.GetComponent<Score>();
        score.DecreaseScoreByPercentage(percentageToReduce);
    }
}
